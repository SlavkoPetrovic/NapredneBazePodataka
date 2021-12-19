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
            
            client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "sifra123");
            try
            {
                client.ConnectAsync().Wait();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            comboBox1.SelectedIndex = 1;

        }
        private async void PopulateInformations()
        {
            listView1.Items.Clear();
            var queryRooms = await client.Cypher
                                .Match("(p:Person)", "(r)-[r1:NEEDS]->(p)")
                                .Where((Person p) => p.Job == comboBox1.SelectedItem.ToString())
                                .Return(r1 => new
                                {
                                    Tasks = r1.As<NeedsRelationship>()
                                })
                               .OrderBy("(r1.DamagePrice)")
                               .ResultsAsync;
            var tasks = queryRooms.ToList();
            foreach (var p in tasks)
            {
                
                ListViewItem item = new ListViewItem(new string[] {p.Tasks.ToDo.ToString(), p.Tasks.Done.ToString(), p.Tasks.DamagePrice.ToString() });
                listView1.Items.Add(item);

            }
          listView1.Refresh();
        }
            private async void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInformations();
        }
    }
}
