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
    public partial class RoomsInformationsForm : Form
    {
        public GraphClient client;
        public RoomsInformationsForm()
        {
            InitializeComponent();
        }

        private void RoomsInformationsForm_Load(object sender, EventArgs e)
        {
            PopulateInformation();
        }

        private async void PopulateInformation()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Naziv Hotela");
            listView1.Columns.Add("Lokacija Hotela");
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Broj");
            listView1.Columns.Add("Sprat");
            listView1.Columns.Add("Broj Kreveta");
            listView1.Columns.Add("CenaPoNocenju");

            listView1.Items.Clear();

            var queryRoom = await client.Cypher
                                        .Match("(r:Room)","(h:Hotel)", "(r) -[r1:PARTOF]->(h)")
                                        .Return((r, h) => new
                                        {
                                            Rooms = r.As<Room>(),
                                            Hotel = h.As<Hotel>()
                                        })
                                        .ResultsAsync;
                                 

            var list = queryRoom.ToList();

            foreach (var p in list)
            {
                ListViewItem item = new ListViewItem(new string[] {p.Hotel.Name,p.Hotel.Location, p.Rooms.ID.ToString(),p.Rooms.Number.ToString(),p.Rooms.Floor.ToString(),
                                                                    p.Rooms.NumberOfBeds.ToString(),p.Rooms.PricePerNight.ToString()});
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)//dodaj
        {
            AddRoomForm form1 = new AddRoomForm();
            form1.client = client;
            if(form1.ShowDialog() ==DialogResult.OK)
            {
                PopulateInformation();
            }

        }

        private void button2_Click(object sender, EventArgs e)//izmeni
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite sobu koju zelite izmeniti");
                return;
            }
            int idSobe = Int32.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            string staraCena = listView1.SelectedItems[0].SubItems[6].Text;
            string stariBrKreveta = listView1.SelectedItems[0].SubItems[5].Text;
            ModifyRoomForm form1 = new ModifyRoomForm(idSobe, staraCena, stariBrKreveta);
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInformation();
            }


        }

        private async void button3_Click(object sender, EventArgs e)//izbrisi
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite sobu koji zelite obrisati");
                return;
            }

            int idSobe = Int32.Parse(listView1.SelectedItems[0].SubItems[2].Text);

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

                    PopulateInformation();


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
