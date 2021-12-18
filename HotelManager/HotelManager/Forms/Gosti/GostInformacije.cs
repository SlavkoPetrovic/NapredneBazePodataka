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

namespace HotelManager.Forms.Gosti
{
    public partial class GostInformacije : Form
    {
        public GraphClient client;
        private Guest gost;
        public GostInformacije()
        {
            InitializeComponent();
        }
        public GostInformacije(Guest gost)
        {
            this.gost = gost;
            InitializeComponent();
        }
        //samo prikaz
        //ovde ce recepcionar moci da vidi informacije o gostima svog hotela
        private void GostInformacije_Load(object sender, EventArgs e)
        {

        }
    }
}
