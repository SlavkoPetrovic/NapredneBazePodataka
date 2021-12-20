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
    public partial class SobaTaskForm : Form
    {
        public GraphClient client;
        int brSobe;
        public SobaTaskForm()
        {
            InitializeComponent();
        }
        public SobaTaskForm(int br)
        {
            InitializeComponent();
            this.brSobe = br;
        }

        private void SobaTaskForm_Load(object sender, EventArgs e)
        {
            Program.LoginName = "majstor@evropa.com";
          
            PopulateInformations();
        }
        private async void PopulateInformations()
        {
            listView1.Items.Clear();
            var queryRooms = await client.Cypher
                                .Match("(p:Person)", "(r)-[r1:NEEDS]->(p)")
                                 .Where((Room r) => r.ID == brSobe)
                                .Return(r1 => r1.As<NeedsRelationship>())
                                .OrderBy("(r1.DamagePrice)")
                                .ResultsAsync;
            var tasks = queryRooms.ToList();

          if(tasks.Count()==0)
          {
                MessageBox.Show("Nema dodatnih troskova za ovu sobu");
                this.Close();
          }
          else
          {
                foreach (var p in tasks)
                {
                    //
                    if(String.IsNullOrEmpty(p.Done))
                    {
                        ListViewItem item = new ListViewItem(new string[] { p.ToDo.ToString(), p.Done.ToString(), p.DamagePrice.ToString() });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
            
        }
    }
}
