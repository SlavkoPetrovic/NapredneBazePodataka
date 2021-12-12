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

        private void tempAddbtn_Click(object sender, EventArgs e)
        {

            //Funkcija radi samo sam je zakomentarisao da se ne bi zeznuli i kliknuli i napravili duplikate
/*            var person = new Person
            {
                Age = 22,
                Email="matetebra@elfak.rs",
                Job ="Administrator",
                Name="Mateja",
                Surname ="Pancic",
                Password ="sifrasifra"
            };

            try
            {
                 client.Cypher
                            .Create("(person:Person $person)")
                            .WithParam("person", person)
                            .ExecuteWithoutResultsAsync();

                MessageBox.Show("Osoba je uspesno dodata");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }*/

        }
        public async Task<List<Person>> GetPersonsAsync()
        {
            var queryPerson = await client.Cypher
                                          .Match("(n:Person)")
                                          .Return(n => n.As<Person>())
                                          .ResultsAsync;


            var list = queryPerson.ToList();
            return list; 
        }

        private async void tempShowbtn_Click(object sender, EventArgs e)
        {
            var persons = await GetPersonsAsync();

            foreach(Person p in persons)
            {
                MessageBox.Show(p.Name);
            }




        }
    }
}
