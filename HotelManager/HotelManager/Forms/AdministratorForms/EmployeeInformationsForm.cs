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
    public partial class EmployeeInformationsForm : Form
    {
        public GraphClient client;
        public EmployeeInformationsForm()
        {
            InitializeComponent();
        }

        private void EmployeeInformationsForm_Load(object sender, EventArgs e)
        {
            PopulateInfo();
        }

        private async void PopulateInfo()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Naziv Hotela");
            listView1.Columns.Add("Lokacija Hotela");
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Email");
            listView1.Columns.Add("Posao");

            listView1.Items.Clear();

            var queryRadnik = await client.Cypher
                                          .Match("(h:Hotel)", "(p:Person)", "(p)-[r:WORKS]->(h)")
                                          .Return((h, p) => new
                                          {
                                              People = p.As<Person>(),
                                              Hotel = h.As<Hotel>()

                                          })
                                          .ResultsAsync;
            var list = queryRadnik.ToList();

            foreach (var p in list)
            {
                ListViewItem item = new ListViewItem(new string[] {p.Hotel.Name,p.Hotel.Location, p.People.Name, p.People.Surname, p.People.Email, p.People.Job });
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Refresh();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddNewEmployeeForm form1 = new AddNewEmployeeForm();
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInfo();
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            string emailOsobe = listView1.SelectedItems[0].SubItems[4].Text;
            ModifyEmployeeForm form1 = new ModifyEmployeeForm(emailOsobe);
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInfo();
            }

        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite radnika kojeg zelite obrisati");
                return;
            }

            string emailOsobe = listView1.SelectedItems[0].SubItems[4].Text;

            string poruka = "Da li ste sigurni da zelite da obrisete izabranog radnika?";
            string title = "Obavestenje";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    await client.Cypher
                                .Match("(p:Person)")
                                .Where((Person p) => p.Email == emailOsobe)
                                .DetachDelete("(p)")
                                .ExecuteWithoutResultsAsync();

                    PopulateInfo();


                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }
    }
}
