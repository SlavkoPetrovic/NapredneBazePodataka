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
    }
}
