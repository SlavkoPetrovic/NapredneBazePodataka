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

namespace HotelManager.Forms.RecepcionarForms
{
    public partial class NoviTaskForm : Form
    {
        public GraphClient client;
        public int nmb;
        public NoviTaskForm()
        {
            InitializeComponent();
        }
        public NoviTaskForm(int n)
        {
            this.nmb = n;
            InitializeComponent();
        }
        private async void btnPosalji_Click(object sender, EventArgs e)
        {
            try
            {


                var str = "";
                int newId = 0;

                var query = await client.Cypher.Match("(s)-[r1:NEEDS]->(p)")
                                   .Return(r1 => r1.As<NeedsRelationship>())
                                   .ResultsAsync;
                var test = query.ToList();
                if (test.Count != 0)
                {
                    var query1 = await client.Cypher.Match("(s)-[r1:NEEDS]->(p)")
                                             .Return(() => Neo4jClient.Cypher.Return.As<int>("MAX(r1.ID)"))
                                             .ResultsAsync;
                    var listID = query1.ToList();
                    MessageBox.Show(listID[0].ToString());
                    newId = listID[0] + 1;
                }


                await client.Cypher
                                      .Match("(h:Hotel)", "(p:Person)", "(r:Room)", "(r) -[r1:PARTOF]->(h)", "(p)-[r2:WORKS]->(h)")
                                      .Where((Room r) => r.ID == nmb)
                                      .AndWhere((Person p) => p.Job == comboBox1.SelectedItem.ToString())
                                      .Merge("(r)-[q:NEEDS{ToDo:'" + tbxTask.Text + "',Done:'" + str + "',DamagePrice:" + 0 + " ,ID: " + newId + " }]->(p)")
                                      .ExecuteWithoutResultsAsync();
                
               
                 

            MessageBox.Show("Posao je uspesno poslat");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }
       

        private void NoviTaskForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
