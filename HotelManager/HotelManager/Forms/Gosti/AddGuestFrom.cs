using HotelManager.DomainModel;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.Forms.Gosti
{
    public partial class AddGuestFrom : Form //Proslediti id sobe kao argument
    {
        private int roomID;
        public GraphClient client;
        public AddGuestFrom()
        {
            InitializeComponent();
        }
        public AddGuestFrom(int roomID)
        {
            this.roomID = roomID;
            InitializeComponent();


        }
 

        private  async void AddReservation_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(docTypeCmbBox.Text) || String.IsNullOrEmpty(DocumentIDTextBox.Text)|| String.IsNullOrEmpty(NameTextBox.Text) 
                || String.IsNullOrEmpty(PicturePathTextBox.Text) || String.IsNullOrEmpty(SurnameTextBox.Text))
            {
                MessageBox.Show("Molimo popunite sva polja!");
                return;
            }

                var r = new ReservedRelationship
            {
                CheckIn = checkInDate.Value,
                CheckOut = CheckOutDate.Value
            };
            var person = new Guest
            {
                DocumentType = docTypeCmbBox.Text,
                ID = Int32.Parse(DocumentIDTextBox.Text),
                Name = NameTextBox.Text,
                PicturePath = PicturePathTextBox.Text,
                Surname = SurnameTextBox.Text
            };

            try
            {
                await client.Cypher
                            .Match("(r:Room)")
                            .Where((Room r) => r.ID==0) //treba ovde da ide roomID to nek promeni onaj koji pravi
                            .Create("(person:Person $person)")
                            .WithParam("person", person)
                            .Merge("(person)-[q:RESERVED{CheckIn: date({day:"+r.CheckIn.Day +", month: "+r.CheckIn.Month+",  year: "+r.CheckIn.Year +"})" +
                                                               ",CheckOut: date({day:"+r.CheckOut.Day + ", month: " + r.CheckOut.Month + ",  year: " + r.CheckOut.Year + "})}]->(r)")
                            
                            //upisuje u relaciji properi tipa DATE voditi racuna o tome!!!!!
                            .ExecuteWithoutResultsAsync();

                MessageBox.Show("Rezervacija je uspesno izvrsena");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void AddGuestFrom_Load(object sender, EventArgs e) //OVO UKLONITI I POVEZATI KLIJENT KAKO TREBA
        {
            docTypeCmbBox.SelectedIndex = 0; // ovo ne dirati
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
        private void choosePictureBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DocumentIDTextBox.Text))
            {
                MessageBox.Show("Molimo unesite broj dokumenta gosta!");
                return;
            }
            var destinationPath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"Downloads";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "(*.jpg;*.jpeg;*.png) |*.jpg;*.jpeg;*.png ";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog.FileName,Path.Combine(destinationPath,DocumentIDTextBox.Text));
                    personPictureBox.Image = Image.FromFile(destinationPath+DocumentIDTextBox.Text);
                    PicturePathTextBox.Text = destinationPath+DocumentIDTextBox.Text;
                }



            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var ime = "Jovan"; // ovo zameniti umesto imena IDGUEST ili posaljite umesto imena room ID i zamenite ovo dole

            var query1 = await client.Cypher
                                     .Match("(p:Person {Name:'" + ime + "'}) , (p)-[r:RESERVED]->(soba) , (soba)-[r1:NEEDS]->(majstor)")
                                     .Return((p, r,soba,r1) => new
                                     {
                                         Osoba = p.As<Guest>(),
                                         Rezervacija = r.As<ReservedRelationship>(),
                                         Soba = soba.As<Room>(),
                                         Popravke = r1.CollectAs<NeedsRelationship>()
                                     })
                                     .ResultsAsync;

            var test = query1.FirstOrDefault(); // vratice mi duplikat iz nekog razloga zato neka ga ovako 

            if(test != null && test.Osoba != null && test.Rezervacija !=null && test.Soba != null)
            {
                int totalPrice = ((int)(test.Rezervacija.CheckOut - test.Rezervacija.CheckIn).TotalDays) * test.Soba.PricePerNight;
                if (test.Popravke != null)
                
                    foreach (var popravke in test.Popravke)
                    {
                        totalPrice = totalPrice + popravke.DamagePrice;
                    }
                MessageBox.Show("Ovoliko je duzan covek: " + totalPrice);
            }



        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var ime = "Jovan"; // isto vazi kao za prethodni post
            var deletePath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\" + "1122"; // umesto 1122 ide guestID!!!!!!!!!
            try // ovo ce obrise gosta i sve njegove veze 
            {

                File.Delete(deletePath);
                await client.Cypher
                            .Match("(p:Person {Name:'" + ime + "'})")
                            .DetachDelete("(p)")
                            .ExecuteWithoutResultsAsync();
                await client.Cypher // ovo ce obrise needs veze
                            .Match("(room:Room {ID:" + 0 + "}), (r)-[r1:NEEDS]->(p)")
                            .Delete("(r1)").ExecuteWithoutResultsAsync();

                MessageBox.Show("Uspesno ste obrisali rezervaciju!");

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }




        }
    }
}
