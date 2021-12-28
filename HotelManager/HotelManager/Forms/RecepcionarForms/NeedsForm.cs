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
    public partial class NeedsForm : Form
    {
        public GraphClient client;
        public int id;
        public NeedsForm()
        {
            InitializeComponent();
 
            //PopulateInformations();
        }
        public NeedsForm(int br)
        {
            InitializeComponent();
            this.id = br;
        }
        private async void PopulateInformations()
        {
            var queryRooms = await client.Cypher
                               .Match("(p:Person)", "(r)-[r1:NEEDS{ID:" + this.id + "}]->(p)")
                               // .Where((Room r) => r.ID == id)
                                 .Return(r1 => r1.As<NeedsRelationship>())
                                .ResultsAsync;
            var tasks = queryRooms.ToList();

            
            textBox3.Text = tasks[0].ToDo.ToString();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await client.Cypher
                                .Match("(p:Person)", "(r)-[r1:NEEDS{ID:" + this.id + "}]->(p)")
                                .Set("r1.Done='" + textBox1.Text + "'")
                                .Set("r1.DamagePrice=" + Int32.Parse(textBox2.Text) + "")
                                .ExecuteWithoutResultsAsync();
                

                MessageBox.Show("Posao je izmenjen");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void NeedsForm_Load(object sender, EventArgs e)
        {
            PopulateInformations();
        }
    }
}
