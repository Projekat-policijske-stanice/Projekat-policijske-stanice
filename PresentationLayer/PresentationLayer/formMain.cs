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
    public partial class formMain : Form
    {
        private readonly IOffenseBusiness offenseBusiness;
        private readonly IPolicemanBusiness policemanBusiness;
        private readonly IVehicleBusiness vehicleBusiness;
        public formMain(IPolicemanBusiness _policemanBusiness, IVehicleBusiness _vehicleBusiness, IOffenseBusiness _offenseBusiness)
        {
            InitializeComponent();
            this.offenseBusiness = _offenseBusiness;
            this.policemanBusiness = _policemanBusiness;
            this.vehicleBusiness = _vehicleBusiness;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonAdministracija_Click(object sender, EventArgs e)
        {
            formAdministration form = new formAdministration(this.policemanBusiness, this.vehicleBusiness);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void buttonZaposlen_Click(object sender, EventArgs e)
        {
            formOffenses form = new formOffenses(this.policemanBusiness, this.vehicleBusiness, this.offenseBusiness);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
