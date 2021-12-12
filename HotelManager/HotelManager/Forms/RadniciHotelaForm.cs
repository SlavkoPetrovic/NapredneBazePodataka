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

namespace HotelManager
{
    public partial class RadniciHotelaForm : Form
    {
        public GraphClient client;
        public RadniciHotelaForm()
        {
            InitializeComponent();
        }

        private void RadniciHotela_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
          

        }

        private async void PopulateInformations()
        {
            listView1.Items.Clear();

            var queryPerson = await client.Cypher
                               .Match("(n:Person)")
                               .Where((Person n) => n.Job == comboBox1.Text) //Prepraviti da pokazuje samo radnike tog hotela
                               .Return(n => n.As<Person>())
                               .ResultsAsync;

            var persons = queryPerson.ToList();

            foreach(Person p in persons)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Name, p.Surname });

                listView1.Items.Add(item);
            }

            listView1.Refresh();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInformations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.HotelName);
            MessageBox.Show(Program.LoginName);
        }
    }
}
