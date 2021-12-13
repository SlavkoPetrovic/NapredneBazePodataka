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
        public GraphClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            //ZA SADA JE OVDE NZM GDE CE DA BUDE
            var query =  client.Cypher
                                  .Match("(p:Person)")
                                  .Where((Person p) => p.Name == Program.LoginName)
                                  .OptionalMatch("(p)-[r:ADMINISTATOR]->(h)") 
                                  .Return(h => h.As<Hotel>())
                                  .ResultsAsync;

            var list = query.Result.FirstOrDefault();
            Program.HotelName = list.Name;
            MessageBox.Show("sadad" + Program.HotelName);


        }

        private async void tempAddbtn_Click(object sender, EventArgs e)
        {

            //Funkcija radi samo sam je zakomentarisao da se ne bi zeznuli i kliknuli i napravili duplikate
            //var person = new Person
            //{
            //    Age = 22,
            //    Email = "aleksandra@elfak.rs",
            //    Job = "Majstor",
            //    Name = "Aleksandra",
            //    Surname = "Djokic",
            //    Password = "sifra3"
            //};

            //try
            //{
            //   await client.Cypher
            //               .Create("(person:Person $person)")
            //               .WithParam("person", person)
            //               .ExecuteWithoutResultsAsync();

            //    MessageBox.Show("Osoba je uspesno dodata");
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}

        }
        private async void tempShowbtn_Click(object sender, EventArgs e)
        {
            var queryPerson = await client.Cypher
                                      .Match("(n:Person)")
                                      .Return(n => n.As<Person>())
                                      .ResultsAsync;


            var list = queryPerson.ToList();


            foreach (Person p in list)
            {
                MessageBox.Show(p.Name);
            }




        }

        private async void relationshipBtn_Click(object sender, EventArgs e)
        {
            var query = client.Cypher
                              .Match("(p:Person)", "(h:Hotel)")
                              .Where((Person p) => p.Name == "Mateja")
                              .AndWhere((Hotel h) => h.Name == "Grand")
                              .Merge("(p)-[r:ADMINISTATOR]->(h)");

            await query.ExecuteWithoutResultsAsync();





        }

        private async void hotelAddBtn_Click(object sender, EventArgs e)
        {
            //var hotel = new Hotel
            //{
            //    Address = "Milosa Obilica 14",
            //    Location = "Pristina",
            //    Name = "Grand"
            //};

            //try
            //{
            //     await client.Cypher
            //               .Create("(hotel:Hotel $hotel)")
            //               .WithParam("hotel", hotel)
            //               .ExecuteWithoutResultsAsync();

            //    MessageBox.Show("Hotel je uspesno dodat");
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);

            //}
        }

        private async void showHotel_Click(object sender, EventArgs e)
        {
            var queryPerson = await client.Cypher
                                    .Match("(n:Hotel)")
                                    .Return(n => n.As<Hotel>())
                                    .ResultsAsync;


            var list = queryPerson.ToList();


            foreach (Hotel p in list)
            {
                MessageBox.Show(p.Name);
            }

        }

        private async void testsdbtn_Click(object sender, EventArgs e)
        {
            var query = await client.Cypher
                                    .Match("(h:Hotel)")
                                    .Where((Hotel h) => h.Name == "Grand")
                                    .OptionalMatch("(h)<-[r:ADMINISTATOR]-(p2:Person)")
                                    .Return(p2 => p2.As<Person>())
                                    .ResultsAsync;

            var list = query.ToList();

            foreach(Person p in list)
            {
                MessageBox.Show(p.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = client.Cypher
                              .Match("(p:Person)", "(h:Hotel)")
                              .Where((Person p) => p.Name == "Mateja")
                              .AndWhere((Hotel h) => h.Name == "Grand")
                              .OptionalMatch("(p) -[r:ADMINISTATOR]->(h)")
                              .Delete("r")
                              .ExecuteWithoutResultsAsync();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new RadniciHotelaForm();
            form1.client = client;
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}

/*   var query = client.Cypher
                              .Match("(p:Person)", "(h:Hotel)")
                              .Where((Person p) => p.Name == "Mateja")
                              .AndWhere((Hotel h) => h.Name == "Grand")
                              .Merge("(p)-[r:ADMINISTATOR]->(h)");

            await query.ExecuteWithoutResultsAsync();
*/