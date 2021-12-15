using HotelManager.DomainModel;
using HotelManager.Forms.AdministratorForms;
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

namespace HotelManager
{
    public partial class LoginForm : Form
    {
        private GraphClient client;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "sifra123");
            try
            {

                client.ConnectAsync().Wait();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var queryPerson = await client.Cypher
                                 .Match("(n:Person)")
                                 .Where((Person n) => n.Email == emailTxtBox.Text)
                                 .Return(n => n.As<Person>())
                                 .ResultsAsync;


                var person = queryPerson.FirstOrDefault();

                
                // moje misljenje je da salt i tokeni nisu potrebni za ovaj vid aplikacije 
                if (person.Password ==  AddNewEmployeeForm.ComputeHash(passwordTxtBox.Text, new SHA256CryptoServiceProvider()))
                {
                    if(person.Job == "Administrator")// ovo treba da zamenim da vidim koji je job i u zavisnosti od toga da mu ucita sta treba
                    {
                        Program.LoginName = person.Email; // ovo je slicno kao sto smo imali localstorage globalna je promenljiva
                        this.Hide();
                        var form1 = new AdminForm(); 
                        form1.client = client;
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
         


        }

    }
}
