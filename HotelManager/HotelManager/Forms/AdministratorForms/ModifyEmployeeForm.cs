using HotelManager.DomainModel;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.Forms.AdministratorForms
{
    public partial class ModifyEmployeeForm : Form
    {
        public GraphClient client;
        private string employeeEmail;
        public ModifyEmployeeForm(string email)
        {
            employeeEmail = email;
            InitializeComponent();
        }

        public ModifyEmployeeForm()
        {
            InitializeComponent();
        }

        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            PopulateInfo();
            PositionCmbBox.SelectedIndex = 0;
            
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
                HotelsCmbBox.Items.Add(p.Name + " " + p.Location);
            }
            HotelsCmbBox.SelectedIndex = 0;
        }

        private async void ModifyEmployeeBtn_Click(object sender, EventArgs e)
        {
            var nameLocation = (HotelsCmbBox.Text.ToString()).Split(" ");
            var name = nameLocation[0];
            var location = nameLocation[1];
            try
            {

                await client.Cypher
                            .Match("(p:Person)","(h1:Hotel)")
                            .Where((Person p) => p.Email == employeeEmail)
                            .AndWhere((Hotel h1) => h1.Location == location)
                            .AndWhere((Hotel h1) => h1.Name == name)
                            .OptionalMatch("(p)-[r:WORKS]->(h)")
                            .Delete("(r)")
                            .Merge("(p)-[r1:WORKS]->(h1)")
                            .Set("p.Job = $newJob")
                            .WithParam("newJob", PositionCmbBox.Text.ToString())
                            .ExecuteWithoutResultsAsync();
                     

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
