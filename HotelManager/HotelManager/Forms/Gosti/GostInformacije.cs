using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.DomainModel;
using HotelManager.Forms.RecepcionarForms;
using Neo4jClient;

namespace HotelManager.Forms.Gosti
{
    public partial class GostInformacije : Form
    {
        public GraphClient client;
        private int roomID;
        private Guest gost;
        private DateTime checkOut;
        public GostInformacije()
        {
            InitializeComponent();
        }
        public GostInformacije(Guest gost, int id, GraphClient client)
        {
            this.gost = gost;
            this.roomID = id;
            this.client = client;
            InitializeComponent();
            setForm();
            disableForm();
        }
        private async void setForm()
        {
            try
            {
                //var destinationPath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\";
                NameTextBox.Text = gost.Name;
                SurnameTextBox.Text = gost.Surname;
                DocumentIDTextBox.Text = gost.ID.ToString();
                if (gost.PicturePath != "")
                {
                    PicturePathTextBox.Text =  gost.PicturePath;
                    //personPictureBox.Image = Image.FromFile(destinationPath + DocumentIDTextBox.Text);
                    personPictureBox.Image = Image.FromFile( gost.PicturePath);
                }
                else PicturePathTextBox.Text = "";
                docTypeCmbBox.SelectedItem = gost.DocumentType;
                var query1 = await client.Cypher
                                         .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba)")
                                         .Return(r => r.As<ReservedRelationship>())
                                         .ResultsAsync;
                ReservedRelationship r = query1.FirstOrDefault();
                checkInDate.Value = r.CheckIn;
                CheckOutDate.Value = checkOut = r.CheckOut;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void disableForm()
        {
            NameTextBox.ReadOnly = true;
            SurnameTextBox.ReadOnly = true;
            DocumentIDTextBox.ReadOnly = true;
            docTypeCmbBox.Enabled = false;
            checkInDate.Enabled = false;
            if (gost.PicturePath == "")
            {
                PicturePathTextBox.ReadOnly = false;
                choosePictureBtn.Enabled = true;
            }
            else
            {
                PicturePathTextBox.ReadOnly = true;
                choosePictureBtn.Enabled = false;
            }
        }
        private void GostInformacije_Load(object sender, EventArgs e)
        {
            docTypeCmbBox.SelectedIndex = 0; 
        }

        private void choosePictureBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DocumentIDTextBox.Text))
            {
                MessageBox.Show("Molimo unesite broj dokumenta gosta!");
                return;
            }
            try { 
            var destinationPath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"Downloads";  //ovo ne radi
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "(*.jpg;*.jpeg;*.png) |*.jpg;*.jpeg;*.png ";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog.FileName, Path.Combine(destinationPath, DocumentIDTextBox.Text+".jpg"));
                    personPictureBox.Image = Image.FromFile(destinationPath + DocumentIDTextBox.Text+".jpg");
                    PicturePathTextBox.Text = destinationPath + DocumentIDTextBox.Text+".jpg";
                }
            }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void changeReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckOutDate.Value == checkOut && gost.PicturePath == PicturePathTextBox.Text)
                    MessageBox.Show("Nema sta da se izmeni");
                else
                {
                    checkOut = CheckOutDate.Value;
                    string newPath = PicturePathTextBox.Text;
                    await client.Cypher
                                .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba)")
                                .Set("r.CheckOut = date({day:" + checkOut.Day + ", month: " + checkOut.Month + ",  year: " + checkOut.Year + "})")
                                .Set("p.PicturePath = $newPath")
                                .WithParam("newPath", newPath)
                                .ExecuteWithoutResultsAsync();
                    MessageBox.Show("izmenjeno");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                var query1 = await client.Cypher
                                     .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba) , (soba)-[r1:NEEDS]->(majstor)")
                                     .Return((p, r, soba, r1) => new
                                     {
                                         Osoba = p.As<Guest>(),
                                         Rezervacija = r.As<ReservedRelationship>(),
                                         Soba = soba.As<Room>(),
                                         Popravke = r1.CollectAs<NeedsRelationship>()
                                     })
                                     .ResultsAsync;
            
            var test = query1.FirstOrDefault(); // vratice mi duplikat iz nekog razloga zato neka ga ovako
            if (test == null)
            {
                var query2 = await client.Cypher
                                     .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba) ")
                                     .Return((p, r, soba) => new
                                     {
                                         Osoba = p.As<Guest>(),
                                         Rezervacija = r.As<ReservedRelationship>(),
                                         Soba = soba.As<Room>()
                                     })
                                     .ResultsAsync;
                var test2 = query2.FirstOrDefault();
                if (test2 != null && test2.Osoba != null && test2.Rezervacija != null && test2.Soba != null)
                {
                    int totalPrice = ((int)(test2.Rezervacija.CheckOut - test2.Rezervacija.CheckIn).TotalDays) * test2.Soba.PricePerNight;
                    MessageBox.Show("Ovoliko je duzan covek: " + totalPrice);
                }
            }
            else
            {
                if (test != null && test.Osoba != null && test.Rezervacija != null && test.Soba != null)
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
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var deletePath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\" + gost.ID +".jpg"; 
            try // ovo ce obrise gosta i sve njegove veze 
            {

                var query1 = await client.Cypher
                                     .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba) , (soba)-[r1:NEEDS]->(majstor)")
                                     .Where((NeedsRelationship r1) => r1.Done == "")
                                     .Return((p, r, soba, r1) => new
                                     {
                                         Osoba = p.As<Guest>(),
                                         Rezervacija = r.As<ReservedRelationship>(),
                                         Soba = soba.As<Room>(),
                                         Popravke = r1.CollectAs<NeedsRelationship>()
                                     })
                                     .ResultsAsync;
                var test = query1.FirstOrDefault(); //ukoliko postoji needs sa done="" vratice !=null
                if(test!=null)
                {
                    MessageBox.Show("Sobu nije moguce osloboditi. Postoje poslovi koji moraju biti zavrseni.");
                    return;
                }
           
                await client.Cypher
                            .Match("(p:Person {ID:" + gost.ID + "})")
                            .DetachDelete("(p)")
                            .ExecuteWithoutResultsAsync();
                await client.Cypher // ovo ce obrise needs veze
                            .Match("(room:Room {ID:" + roomID + "}), (r)-[r1:NEEDS]->(p)")
                            .Delete("(r1)").ExecuteWithoutResultsAsync();
                personPictureBox.Image?.Dispose();
                File.Delete(deletePath);
                MessageBox.Show("Uspesno ste obrisali rezervaciju!");

                this.DialogResult = DialogResult.OK;
                this.Close();
                File.Delete(deletePath);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var query1 = await client.Cypher
                                     .Match("(p:Person {ID:" + gost.ID + "}) , (p)-[r:RESERVED]->(soba) ")
                                     .Return(soba => soba.As<Room>())
                                     .ResultsAsync;

            var s = query1.ToList(); 
            int IDsobe = Int32.Parse(s[0].ID.ToString());
            SobaTaskForm form1 = new SobaTaskForm(IDsobe);
            form1.client = client;
            if (form1.ShowDialog() == DialogResult.OK)
            {
               //PopulateInformations();
            }
        }
    }
}
