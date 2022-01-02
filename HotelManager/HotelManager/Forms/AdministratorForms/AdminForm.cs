using Neo4jClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.Forms.AdministratorForms
{
    public partial class AdminForm : Form
    {
        public GraphClient client;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CreateHotelBtn_Click(object sender, EventArgs e)
        {

        }

        private void showHotelsbtn_Click(object sender, EventArgs e)
        {
            HotelsInformationsForm form1 = new HotelsInformationsForm();
            form1.client = client;
            form1.Show();
        }

        private void showWorkersbtn_Click(object sender, EventArgs e)
        {
            EmployeeInformationsForm form1 = new EmployeeInformationsForm();
            form1.client = client;
            form1.Show();
        }

        private void showroomsbtn_Click(object sender, EventArgs e)
        {
            RoomsInformationsForm form1 =new RoomsInformationsForm();
            form1.client = client;
            form1.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

               SoundPlayer simpleSound = new SoundPlayer(@"C:\NapredneBazePodataka\HotelManager\HotelManager\resources\Marija MaXima - Vucic Aleksandar.wav");
               simpleSound.Play();

        }
    }
}
