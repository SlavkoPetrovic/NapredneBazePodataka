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
using HotelManager.Forms.Gosti;
using HotelManager.Forms.RecepcionarForms;

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
                    ListViewItem item = new ListViewItem(new string[] {r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString(), r.ID.ToString() });
                    listViewListaSoba.Items.Add(item);
                }
                listViewListaSoba.Columns[4].Width = 0;
                buttonRezervisiSobu.Enabled = true;
                buttonOslobodiSobu.Enabled = true;
                buttonProslediPosao.Enabled = true;
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
                    ListViewItem item = new ListViewItem(new string[] { r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString(), r.ID.ToString() });

                    listViewListaSoba.Items.Add(item);
                }
                listViewListaSoba.Columns[4].Width = 0;
                buttonRezervisiSobu.Enabled = true;
                buttonOslobodiSobu.Enabled = false;
                buttonProslediPosao.Enabled = false;
            }
            else
            {
                var queryRooms = await client.Cypher
                               .Match("(h:Hotel)", "(r:Room)", "(r)-[r1: PARTOF]->(h)", "(p)-[r2: RESERVED]->(r)")
                               .Where((Hotel h) => h.Name == hotelName)
                               .AndWhere((Hotel h) => h.Location == hotelLocation)
                               .Return(r => r.As<Room>())
                               .OrderBy("(r.Floor)", "(r.Number)")
                               .ResultsAsync;
                var rooms = queryRooms.ToList();
                foreach (Room r in rooms)
                {

                    ListViewItem item = new ListViewItem(new string[] {r.Floor.ToString(), r.Number.ToString(), r.NumberOfBeds.ToString(), r.PricePerNight.ToString(), r.ID.ToString() });
                    listViewListaSoba.Items.Add(item);
                }
                listViewListaSoba.Columns[4].Width = 0;
                buttonOslobodiSobu.Enabled = true;
                buttonRezervisiSobu.Enabled = false;
                buttonProslediPosao.Enabled = true;
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
            if (listViewListaSoba.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite sobu");
                return;
            }
            try
            {
                int IDsobe = Int32.Parse(listViewListaSoba.SelectedItems[0].SubItems[4].Text);
                var queryRooms = client.Cypher
                                 .Match("(p:Person)", "(r:Room)", "(p)-[r1:RESERVED]->(r)")
                                 .Where((Room r) => r.ID == IDsobe)
                                 .Return(p => p.As<Guest>())
                                 .ResultsAsync;
                var g = queryRooms.Result.ToList();
                if (g.Count > 0)
                {
                   MessageBox.Show("Soba je zauzeta");
                   return;
                }
                AddGuestFrom form1 = new AddGuestFrom(IDsobe);
                form1.client = client;
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInformations();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void buttonOslobodiSobu_Click(object sender, EventArgs e)
        {
            if (listViewListaSoba.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite sobu");
                return;
            }
            try
            {
                int IDsobe = Int32.Parse(listViewListaSoba.SelectedItems[0].SubItems[4].Text);
                var queryRooms = client.Cypher
                                   .Match("(p:Person)", "(r:Room)", "(p)-[r1:RESERVED]->(r)")
                                   .Where((Room r) => r.ID == IDsobe)
                                   .Return(p => p.As<Guest>())
                                   .ResultsAsync;
                var g = queryRooms.Result.ToList();
                if (g.Count == 0)
                {
                    MessageBox.Show("Soba nije rezervisana");
                    return;
                }
                GostInformacije form1 = new GostInformacije(g[0], IDsobe, client);
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    PopulateInformations();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonProslediPosao_Click(object sender, EventArgs e)
        {
            if (listViewListaSoba.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite sobu");
                return;
            }
            int IDsobe = Int32.Parse(listViewListaSoba.SelectedItems[0].SubItems[4].Text);
            var queryRooms = client.Cypher
                               .Match("(p:Person)", "(r:Room)", "(p)-[r1:RESERVED]->(r)")
                               .Where((Room r) => r.ID == IDsobe)
                               .Return(p => p.As<Guest>())
                               .ResultsAsync;
            var g = queryRooms.Result.ToList();
            if (g.Count == 0)
            {
                MessageBox.Show("Soba nije rezervisana");
                return;
            }
            //otvori forma za prosledjivanje poslova
            // int IDsobe = Int32.Parse(listViewListaSoba.SelectedItems[0].SubItems[4].Text);
            // string brSobe = listViewListaSoba.SelectedItems[0].SubItems[1].Text;
            NoviTaskForm form1 = new NoviTaskForm(IDsobe);
            form1.client = client;  
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInformations();
            }
            
        }

    }
}
