using HotelManager.DomainModel;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.Forms.AdministratorForms
{
    public partial class AddNewEmployeeForm : Form
    {
        public GraphClient client;
        private bool hotelOption;
        private string hname;
        private string hlocation;
        public AddNewEmployeeForm()
        {
            InitializeComponent();
            hotelOption = true;
            HotelComboBox.Visible = true;
            label1.Visible = true;
        }
        public AddNewEmployeeForm(string hotelName,string hotelLocation)
        {
            hname = hotelName;
            hlocation = hotelLocation;
            InitializeComponent();
            hotelOption = false;
            HotelComboBox.Visible = false;
            label1.Visible = false;
        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {

            if(hotelOption ==true)
            {
                PopulateInfo();
            }
        }
        private async void PopulateInfo()
        {
            var queryPerson = await client.Cypher
                                   .Match("(n:Hotel)")
                                   .Return(n => n.As<Hotel>())
                                   .ResultsAsync;


            var list = queryPerson.ToList();


            foreach (Hotel p in list)
            {
                HotelComboBox.Items.Add(p.Name + " " + p.Location);
            }

        }

        private async void AddNewEmployee_Click(object sender, EventArgs e)
        {
            var query = await client.Cypher.Match("(p:Person)")
                                        .Return(() => Neo4jClient.Cypher.Return.As<int>("MAX(p.ID)"))
                                        .ResultsAsync;

            var listID = query.ToList();
            var newId = listID[0] + 1;

            string hPassword = ComputeHash(PasswordTxtBox.Text, new SHA256CryptoServiceProvider());
            //nema salt zato sto bi aplikacija bila lokalna za neku firmu i bezbednost nije od veliko znacaja

            var person = new Person
            {
                Email = EmailTxtBox.Text,
                Job = comboBox1.SelectedItem.ToString(),
                ID = newId,
                Name = NameTxtBox.Text,
                Surname = SurnameTxtBox.Text,
                Password = hPassword
            };
            if(hotelOption == true)
            {
                var nameAndLocation = HotelComboBox.Text.Split(" ");
                hname = nameAndLocation[0];
                hlocation = nameAndLocation[1]; // Mora ovako zato sto javlja gresku u suprotnom
            }

            try
            {
                await client.Cypher
                            .Match("(h:Hotel)")
                            .Where((Hotel h) => h.Name == hname)
                            .AndWhere((Hotel h) => h.Location == hlocation)
                            .Create("(person:Person $person)")
                            .WithParam("person", person)
                            .Merge("(person)-[r:WORKS]->(h)")
                            .ExecuteWithoutResultsAsync();

                MessageBox.Show("Korisnik je uspesno dodat");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }





        }

        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
