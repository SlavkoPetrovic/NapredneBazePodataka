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
            if(String.IsNullOrEmpty(LocationTxtBox.Text) || String.IsNullOrEmpty(nameTxtBox.Text) || String.IsNullOrEmpty(addressTxtBox.Text))
            {
                MessageBox.Show("Molimo popunite sva polja!");
                return;
            }

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
                          .Where((Person p) => p.Email == Program.LoginName)//zameniti sa Program.LoginName
                          .Create("(hotel:Hotel $hotel)")
                          .WithParam("hotel", hotel)
                          .Merge("(p)-[r:MANAGE]->(hotel)")
                          .ExecuteWithoutResultsAsync();

                MessageBox.Show("Hotel je uspesno dodat");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }

        }

        private void AddHotelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
