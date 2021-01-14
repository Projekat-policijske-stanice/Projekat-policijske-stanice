using Shared.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class formAdministration : Form
    {
        private readonly IPolicemanBusiness policemanBusiness;
        private readonly IVehicleBusiness vehicleBusiness;
        public formAdministration(IPolicemanBusiness _policemanBusiness, IVehicleBusiness _vehicleBusiness)
        {
            InitializeComponent();
            this.policemanBusiness = _policemanBusiness;
            this.vehicleBusiness = _vehicleBusiness;
        }
        private void buttonAddPoliceman_Click(object sender, EventArgs e)
        {
           
            formPolicemen form2 = new formPolicemen(this.policemanBusiness);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            formVehicles form2 = new formVehicles(this.vehicleBusiness);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
