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
    public partial class AddGuestFrom : Form 
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
                 || String.IsNullOrEmpty(SurnameTextBox.Text))
            {
                MessageBox.Show("Molimo popunite sva polja!");
                return;
            }
            if (String.IsNullOrEmpty(PicturePathTextBox.Text))
                PicturePathTextBox.Text = "";
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
                            .Where((Room r) => r.ID==roomID) 
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
        private void AddGuestFrom_Load(object sender, EventArgs e) 
        {
            docTypeCmbBox.SelectedIndex = 0; // ovo ne dirati
        }
        private void choosePictureBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DocumentIDTextBox.Text))
            {
                MessageBox.Show("Molimo unesite broj dokumenta gosta!");
                return;
            }
            try
            {
                var destinationPath = @"D:\NapredneBazePodataka\HotelManager\HotelManager\resources\";
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = @"Downloads";
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Filter = "(*.jpg;*.jpeg;*.png) |*.jpg;*.jpeg;*.png ";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(openFileDialog.FileName, destinationPath + DocumentIDTextBox.Text + ".jpg");
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
    }
}
