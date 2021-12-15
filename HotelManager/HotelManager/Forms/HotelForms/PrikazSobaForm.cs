using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.DomainModel;
using Neo4jClient;

namespace HotelManager.Forms.Hoteli
{
    public partial class PrikazSobaForm : Form
    {
        public GraphClient client;
        public PrikazSobaForm()
        {
            InitializeComponent();
        }

        private void PrikazSoba_Load(object sender, EventArgs e)
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
            comboBoxOdabirTipaSobe.SelectedIndex = 0;
            //PopulateInformations();
        }
        private async void PopulateInformations()
        {
            listViewListaSoba.Items.Clear();
            string hotelName = Program.HotelName;
            string hotelLocation = Program.HotelLocation;
            if (comboBoxOdabirTipaSobe.SelectedIndex == 0)
            {
                 var queryRooms = await client.Cypher
                                .Match("(h:Hotel)", "(r:Room)", "(r)-[r1: PARTOF]->(h)")
                                .Where((Hotel h) => h.Name == hotelName)
                                .AndWhere((Hotel h) => h.Location == hotelLocation)
                                .Return(r => r.As<Room>())
                                .OrderBy("(r.Floor)" , "(r.Number)")
                                .ResultsAsync;
                var rooms = queryRooms.ToList();
                foreach (Room r in rooms)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString() });
                    listViewListaSoba.Items.Add(item);
                }
                buttonRezervisiSobu.Enabled = true;
                buttonOslobodiSobu.Enabled = true;
            }
            else if(comboBoxOdabirTipaSobe.SelectedIndex ==1)
            {
                var queryRooms = await client.Cypher
                              .Match("(r:Room)", "(h:Hotel)", "(r)-[r1: PARTOF]->(h)")
                              .Where("NOT (r)<-[: RESERVED]-()")
                              .AndWhere((Hotel h) => h.Name == hotelName)
                              .AndWhere((Hotel h) => h.Location == hotelLocation)
                              .Return(r => r.As<Room>())
                              .OrderBy("(r.Floor)", "(r.Number)")
                              .ResultsAsync;
                var rooms = queryRooms.ToList();
                foreach (Room r in rooms)
                {
                    ListViewItem item = new ListViewItem(new string[] { r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString() });

                    listViewListaSoba.Items.Add(item);
                }
                buttonRezervisiSobu.Enabled = true;
                buttonOslobodiSobu.Enabled = false;
            }
            else
            {
                var queryRooms = await client.Cypher
                               .Match("(h:Hotel)", "(r:Room)", "(r)-[r1: PARTOF]->(h)", "(p)-[r2: RESERVED]->(r)")
                               //.Where((Hotel h) => h.Name == hotelName)
                               //.AndWhere((Hotel h) => h.Location == hotelLocation)
                               .Return(r => r.As<Room>())
                               .OrderBy("(r.Floor)", "(r.Number)")
                               .ResultsAsync;
                var rooms = queryRooms.ToList();
                foreach (Room r in rooms)
                {

                    ListViewItem item = new ListViewItem(new string[] { r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString() });
                    listViewListaSoba.Items.Add(item);
                }
                buttonOslobodiSobu.Enabled = true;
                buttonRezervisiSobu.Enabled = false;
            }
            //listViewListaSoba.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listViewListaSoba.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewListaSoba.Refresh();
        }
        private void comboBoxOdabirTipaSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInformations();
        }

        private void buttonRezervisiSobu_Click(object sender, EventArgs e)
        {
            if (comboBoxOdabirTipaSobe.SelectedIndex == 0)
            {
                checkReserved(2);
            }
            //ispitaj dal je slobodna soba prvo
            //otvori forma za rezervaciju sobe
            /*AddRoomForm form1 = new AddRoomForm();
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInformation();
            }*/
        }
        private async void checkReserved(int room)
        {
            //ispituje dal je soba sa id room slobodna
            var queryRooms = await client.Cypher
                               .Match("(p:Person)","(r:Room)", "(p)-[r1:RESERVED]->(r)")
                               .Where((Room r) => r.ID == 1)
                               .Return(p => p.As<Guest>())
                               .ResultsAsync;
            var g = queryRooms.ToList();
            foreach (Guest r in g)
            {
                MessageBox.Show(r.Name);
            }
        }
        private void buttonOslobodiSobu_Click(object sender, EventArgs e)
        {
            var queryRooms =  client.Cypher
                               .Match("(p:Person)", "(r:Room)", "(p)-[r1:RESERVED]->(r)")
                               .Where((Room r) => r.ID == 1)
                               .Return(p => p.As<Guest>())
                               .ResultsAsync;
            var g = queryRooms.Result.ToList();
            foreach (Guest r in g)
            {
                MessageBox.Show(r.Name);
            }
        }

        private void buttonProslediPosao_Click(object sender, EventArgs e)
        {
            //otvori forma za prosledjivanje poslova
        }

        private void listViewListaSoba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
