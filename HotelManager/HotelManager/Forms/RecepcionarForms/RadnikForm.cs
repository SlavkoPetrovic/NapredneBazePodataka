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
using HotelManager.Forms;
using HotelManager.Forms.RecepcionarForms;

namespace HotelManager.Forms.RecepcionarForms
{
    public partial class RadnikForm : Form
    {
        public GraphClient client;
        public RadnikForm()
        {
            InitializeComponent();
        }
        private void RadnikForm_Load(object sender, EventArgs e)
        {
           // Program.LoginName = "majstor@evropa.com";
            
            PopulateInformations();
        }

        private async void PopulateInformations()
        {
            listView1.Items.Clear();
            var queryRooms = await client.Cypher
                                .Match("(p:Person {Email:'" + Program.LoginName + "'})", "(r)-[r1:NEEDS]->(p)")
                                .Return(r1 => r1.As<NeedsRelationship>())
                                .OrderBy("(r1.DamagePrice)")
                                .ResultsAsync;
            var tasks = queryRooms.ToList();

            foreach (var p in tasks)
            {
                if (String.IsNullOrEmpty(p.Done))
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ToDo.ToString(), p.Done.ToString(), p.DamagePrice.ToString() });
                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            //otvori forma za prosledjivanje poslova
            //int IDsobe = Int32.Parse(listViewListaSoba.SelectedItems[0].SubItems[4].Text);
            // string brSobe = listViewListaSoba.SelectedItems[0].SubItems[1].Text;
            NeedsForm form1 = new NeedsForm();
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
                PopulateInformations();
            }
            /* await client.Cypher
                                 .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba)")
                                 .Set("r.CheckOut = date({day:" + checkOut.Day + ", month: " + checkOut.Month + ",  year: " + checkOut.Year + "})")
                                 .Set("p.PicturePath = $newPath")
                                 .WithParam("newPath", newPath)
                                 .ExecuteWithoutResultsAsync();
             MessageBox.Show("izmenjeno");
             this.DialogResult = DialogResult.OK;
             this.Close();

             if (listView1.SelectedItems[0].SubItems[2].Text == "")
             {
                 MessageBox.Show("Morate izmeniti cenu popravke");
             }*/

        }


       
    }
}
