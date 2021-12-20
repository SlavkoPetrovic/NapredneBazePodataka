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
            this.id = 0;
            PopulateInformations();
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
                               //.Set("r1.Done='" + textBox1.Text + "'")
                               //.Set("r1.DamagePrice='" + textBox2.Text + "'")
                               .Return(r1 => r1.As<NeedsRelationship>())
                               .OrderBy("(r1.DamagePrice)")
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
                                .Set("r1.DamagePrice='" + textBox2.Text + "'")
                                //.Return(r1 => r1.As<NeedsRelationship>())
                                .OrderBy("(r1.DamagePrice)")
                                .ExecuteWithoutResultsAsync();
                
                //textBox3.Text = tasks[0].ToDo.ToString();
                MessageBox.Show("Posao je izmenjen");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
