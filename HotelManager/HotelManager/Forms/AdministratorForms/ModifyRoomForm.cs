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
    public partial class ModifyRoomForm : Form
    {
        public GraphClient client;
        private int roomId;
        public ModifyRoomForm()
        {
            InitializeComponent();
        }
        public ModifyRoomForm(int id,string staraCena,string starBrojKreveta)
        {

            roomId = id;
            InitializeComponent();
            PricePerNightTxtBox.Text = staraCena;
            numOfBedsTxtBox.Text = starBrojKreveta;
        }

        private void ModifyRoomForm_Load(object sender, EventArgs e)
        {

        }

        private async void modifyBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(PricePerNightTxtBox.Text) || String.IsNullOrEmpty(numOfBedsTxtBox.Text))
            {
                MessageBox.Show("Polja ne smeju biti prazna");
                return;
            }
            int newPrice = Int32.Parse(PricePerNightTxtBox.Text);
            int newNumOfBeds = Int32.Parse(numOfBedsTxtBox.Text);

            try
            {
                await client.Cypher
                            .Match("(r:Room)")
                            .Where((Room r) => r.ID == roomId)
                            .Set("r.PricePerNight = $newPrice")
                            .WithParam("newPrice", newPrice)
                            .Set("r.NumberOfBeds = $newNumOfBeds")
                            .WithParam("newNumOfBeds", newNumOfBeds)
                            .ExecuteWithoutResultsAsync();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
    }
}
