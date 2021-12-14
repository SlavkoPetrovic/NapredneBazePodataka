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
    public partial class HotelsInformations : Form
    {
        public GraphClient client;
        public HotelsInformations()
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
            hotelListView.Refresh();

        }

        private void HotelsInformations_Load(object sender, EventArgs e)
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

            PopulateInfo();

        }
    }
}
