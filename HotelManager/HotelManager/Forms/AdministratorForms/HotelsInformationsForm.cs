using HotelManager.DomainModel;
using HotelManager.Forms.HotelForms;
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
    public partial class HotelsInformationsForm : Form
    {
        public GraphClient client;
        public HotelsInformationsForm()
        {
            InitializeComponent();
        }
        private async void  PopulateInfo()
        {
            hotelListView.Items.Clear();

            //Prvobitni plan je bio da vrati i broj soba ali nije moguce koristiti count funkciju vise puta
            //dodacu ako provalim kako da uradim to
            var queryHotels = await client.Cypher
                                          .Match("(h:Hotel)")
                                          .OptionalMatch("(p)-[r:WORKS]->(h)")
                                          .Return((h,r) =>new //ovo je ono sto sam rekao da cu da provalim
                                                              //kako se vracaju vise vrednosti, vracaju se kao anonimni tipovi
                                          {
                                              Hotels = h.As<Hotel>(),
                                              CountWorkers = r.Count(),
                                          })
                                          .ResultsAsync;

            var list = queryHotels.ToList();
            foreach(var thing in list)
            {
                ListViewItem item = new ListViewItem(new string[] {thing.Hotels.Name,thing.Hotels.Location,thing.Hotels.Address,
                                                     thing.CountWorkers.ToString() });
                hotelListView.Items.Add(item);
            }
            hotelListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            hotelListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
           // hotelListView.Columns[0].Width = 0;
            hotelListView.Refresh();

        }

        private void HotelsInformations_Load(object sender, EventArgs e)
        {
            PopulateInfo();
        }

        private void AddNewHotelBtn_Click(object sender, EventArgs e)
        {
            AddHotelForm form1 = new AddHotelForm();
            form1.client = client;
            if(form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInfo();
            }
        }

        private async void DeleteHotelBtn_Click(object sender, EventArgs e)
        {
            if(hotelListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite hotel koji zelite obrisati");
                return;
            }

            string nazivHotela = hotelListView.SelectedItems[0].SubItems[0].Text;
            string lokacijaHotela = hotelListView.SelectedItems[0].SubItems[1].Text;
   
            string poruka = "Da li ste sigurni da zelite da obrisete izabrani hotel?";
            string title = "Obavestenje";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    await client.Cypher.Match("(h:Hotel)")
                            .Where((Hotel h) => h.Name == nazivHotela)
                            .AndWhere((Hotel h) => h.Location == lokacijaHotela)
                            .DetachDelete("(h)").ExecuteWithoutResultsAsync();

                    PopulateInfo();
                             

                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void ShowHotelBtn_Click(object sender, EventArgs e)
        {
            if(hotelListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite hotel koji zelite da pogledate");
                return;
            }
            string nazivHotela = hotelListView.SelectedItems[0].SubItems[0].Text;
            string lokacijaHotela = hotelListView.SelectedItems[0].SubItems[1].Text;

            HotelInfoForm form1 = new HotelInfoForm(nazivHotela,lokacijaHotela);
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInfo();
            }



        }

        private void hotelListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = hotelListView.Columns[e.ColumnIndex].Width;
        }
    }
}
