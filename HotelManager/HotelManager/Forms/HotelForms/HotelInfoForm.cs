using HotelManager.DomainModel;
using HotelManager.Forms.AdministratorForms;
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

namespace HotelManager.Forms.HotelForms
{
    public partial class HotelInfoForm : Form
    {
        public GraphClient client;
        private string naziv;
        private string lokacija;

        public HotelInfoForm()
        {
            InitializeComponent();
        }
        public HotelInfoForm(string nazivHotela, string lokacijaHotela)
        {
            InitializeComponent();
            naziv = nazivHotela;
            lokacija = lokacijaHotela;

        }

        private void HotelInfoForm_Load(object sender, EventArgs e)
        {
            PrikaziCmbBox.SelectedIndex = 0;
       
        }
        private async void PopulateInfo()
        {
            if(PrikaziCmbBox.SelectedIndex ==0)
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("Ime");
                listView1.Columns.Add("Prezime");
                listView1.Columns.Add("Email");
                listView1.Columns.Add("Posao");

                listView1.Items.Clear();

                var queryRadnik = await client.Cypher
                                              .Match("(h:Hotel)")
                                              .Where((Hotel h) => h.Name == naziv)
                                              .AndWhere((Hotel h) => h.Location ==lokacija)
                                              .OptionalMatch("(p)-[r:WORKS]->(h)")
                                              .Return(p => p.As<Person>())
                                              .ResultsAsync;
                var list = queryRadnik.ToList();
                if(list==null)
                {
                    MessageBox.Show("Nema nicega");
                    return;
                }
                foreach(var p in list)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Name, p.Surname, p.Email, p.Job });
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listView1.Refresh();

            }
            else
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Broj");
                listView1.Columns.Add("Sprat");
                listView1.Columns.Add("Broj Kreveta");
                listView1.Columns.Add("CenaPoNocenju");

                listView1.Items.Clear();

                var queryRoom = await client.Cypher
                                             .Match("(h:Hotel)")
                                              .Where((Hotel h) => h.Name == naziv)
                                              .AndWhere((Hotel h) => h.Location == lokacija)
                                              .OptionalMatch("(s)-[r:PARTOF]->(h)")
                                              .Return(s => s.As<Room>())
                                              .ResultsAsync;

                var list = queryRoom.ToList();
                if (list.Count() == 0)
                {
                    MessageBox.Show("Nema nicega");
                    return;
                }
                foreach (var p in list)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Number.ToString(), p.Floor.ToString(), p.NumberOfBeds.ToString() ,p.PricePerNight.ToString() });
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listView1.Refresh();

            }

        }

        private void PrikaziCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PrikaziCmbBox.SelectedIndex == 0) //radnik
            {
                AddNewEmployeeForm form1 = new AddNewEmployeeForm(naziv,lokacija);
                form1.client = client;
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInfo();
                }

            }
            else//soba
            {
                AddRoomForm form1 = new AddRoomForm(naziv, lokacija);
                form1.client = client;
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInfo();
                }

            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (PrikaziCmbBox.SelectedIndex == 0) //radnik
            {
                if (listView1.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Odaberite hotel koji zelite obrisati");
                    return;
                }

                string emailOsobe = listView1.SelectedItems[0].SubItems[2].Text;

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
            else//soba
            {
                int idSobe = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                string poruka = "Da li ste sigurni da zelite da obrisete izabranu sobu?";
                string title = "Obavestenje";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(poruka, title, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await client.Cypher
                                    .Match("(r:Room)")
                                    .Where((Room r) => r.ID == idSobe)
                                    .DetachDelete("(r)")
                                    .ExecuteWithoutResultsAsync();

                        PopulateInfo();


                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)//izmeni
        {
            if (PrikaziCmbBox.SelectedIndex == 0) //radnik
            {
                string emailOsobe = listView1.SelectedItems[0].SubItems[2].Text;
                ModifyEmployeeForm form1 = new ModifyEmployeeForm(emailOsobe);
                form1.client = client;
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInfo();
                }

            }
            else//soba
            {
                int idSobe = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string staraCena = listView1.SelectedItems[0].SubItems[4].Text;
                string stariBrKreveta = listView1.SelectedItems[0].SubItems[3].Text;
                ModifyRoomForm form1 = new ModifyRoomForm(idSobe,staraCena,stariBrKreveta);
                form1.client = client;
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInfo();
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
