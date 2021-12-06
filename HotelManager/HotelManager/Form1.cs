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
using Neo4jClient.Cypher;

namespace HotelManager
{
    public partial class Form1 : Form
    {
        private GraphClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "password");
            try
            {
                //client.Connect();  //ovo je on pisao nece
                client.ConnectAsync();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
