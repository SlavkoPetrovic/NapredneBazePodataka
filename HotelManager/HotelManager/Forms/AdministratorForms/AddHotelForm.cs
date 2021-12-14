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

namespace HotelManager.Forms
{
    public partial class AddHotelForm : Form
    {
        public GraphClient client;
        public AddHotelForm()
        {
            InitializeComponent();
        }

        private async void AddHotelBtn_Click(object sender, EventArgs e)
        {

            var hotel = new Hotel
            {
                Name = nameTxtBox.Text,
                Location=LocationTxtBox.Text,
                Address = addressTxtBox.Text
            };

            try
            {
                await client.Cypher
                          .Match("(p:Person)")
                          .Where((Person p) => p.Email == "slavkopetrovic14@gmail.com")//zameniti sa Program.LoginName
                          .Create("(hotel:Hotel $hotel)")
                          .WithParam("hotel", hotel)
                          .Merge("(p)-[r:MANAGE]->(hotel)")
                          .ExecuteWithoutResultsAsync();

                MessageBox.Show("Hotel je uspesno dodat");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }

        }

        private void AddHotelForm_Load(object sender, EventArgs e)
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
        }
    }
}
