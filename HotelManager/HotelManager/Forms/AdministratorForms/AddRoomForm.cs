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

namespace HotelManager.Forms.AdministratorForms
{
    public partial class AddRoomForm : Form
    {
        public GraphClient client;
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private async void AddRoomBtn_Click(object sender, EventArgs e)
        {
            var query = await client.Cypher.Match("(r:Room)")
                                         .Return(() => Neo4jClient.Cypher.Return.As<int>("MAX(r.ID)"))
                                         .ResultsAsync;

            var listID = query.ToList();
            var newId = listID[0] + 1;
            var room = new Room
            {
                Number = Int32.Parse(RoomNumberTxtBox.Text),
                Floor = Int32.Parse(FloorNumberTxtBox.Text),
                PricePerNight = Int32.Parse(PricePerNightTxtBox.Text),
                NumberOfBeds = Int32.Parse(NumOfBedsTxtBox.Text),
                ID = newId 
            };

            

            var nameAndLocation = HotelComboBox.Text.Split(" ");
            var name = nameAndLocation[0];
            var location = nameAndLocation[1]; // Mora ovako zato sto javlja gresku u suprotnom

            try
            {
                await client.Cypher
                          .Match("(h:Hotel)")
                          .Where((Hotel h) => h.Name == name)
                          .AndWhere((Hotel h) => h.Location == location)
                          .Create("(room:Room $room)")
                          .WithParam("room", room)
                          .Merge("(room)-[r:PARTOF]->(h)")
                          .ExecuteWithoutResultsAsync();

                MessageBox.Show("Soba je uspesno dodata");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }



        }

        private void AddRoomForm_Load(object sender, EventArgs e)
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

            PopulateInfo();
        }
        private async void PopulateInfo()
        {
            var queryPerson = await client.Cypher
                                   .Match("(n:Hotel)")
                                   .Return(n => n.As<Hotel>())
                                   .ResultsAsync;


            var list = queryPerson.ToList();


            foreach (Hotel p in list)
            {
                HotelComboBox.Items.Add(p.Name + " " + p.Location);
            }
            
        }
    }
}
