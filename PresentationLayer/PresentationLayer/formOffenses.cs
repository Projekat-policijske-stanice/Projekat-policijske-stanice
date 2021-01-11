using BusinessLayer;
using DataLayer.Models;
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
    public partial class formOffenses : Form
    {
        private readonly OffenseBusiness offenseBusiness;
        private readonly PolicemanBusiness policemanBusiness;
        private readonly VehicleBusiness vehicleBusiness;
        
        public formOffenses()
        {
            InitializeComponent();
            this.offenseBusiness = new OffenseBusiness();
            this.policemanBusiness = new PolicemanBusiness();
            this.vehicleBusiness = new VehicleBusiness();
        }

        private void formOffenses_Load(object sender, EventArgs e)
        {
            List<Offense> offensesList = this.offenseBusiness.GetAllOffenses();
            dataGridViewOffense.DataSource = offensesList;
            dataGridViewOffense.Columns["Date"].Width = 150;

            List<Policeman> policemanList = this.policemanBusiness.GetPolicemenAtWork();
            dataGridViewPolicemen.DataSource = policemanList;
            dataGridViewPolicemen.Columns["JMBG"].Visible = false;
            dataGridViewPolicemen.Columns["Gender"].Visible = false;
            dataGridViewPolicemen.Columns["Status"].Visible = false;

            List<Vehicle> vehicleList = this.vehicleBusiness.GetAvailableVehicles();
            dataGridViewVehicles.DataSource = vehicleList;
            dataGridViewVehicles.Columns["Consumption"].Visible = false;
            dataGridViewVehicles.Columns["Condition"].Visible = false;
        }
        private void Zaposlen_Load(object sender, EventArgs e)
        {
            
        }
        void ClearTextBox()
        {
            textBoxVehicle.Text = "";
            textBoxPoliceman.Text = "";
        }

        private void dataGridViewPolicemen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPoliceman.Text = Convert.ToString(dataGridViewPolicemen.SelectedRows[0].Cells[0].Value);
        }

        private void dataGridViewVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxVehicle.Text = Convert.ToString(dataGridViewVehicles.SelectedRows[0].Cells[0].Value);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Text != "" && textBoxVehicle.Text != "" && textBoxPoliceman.Text != "") 
            {
                Offense o = new Offense();
                o.VehicleId = Convert.ToInt32(textBoxVehicle.Text);
                o.PolicemanId = Convert.ToInt32(textBoxPoliceman.Text);
                o.Date = Convert.ToDateTime(dateTimePicker.Value);
                if (this.offenseBusiness.InsertOffense(o))
                {
                    MessageBox.Show("Uspesno registrovanje prekrsaja");
                    ClearTextBox();
                    List<Offense> offensesList = this.offenseBusiness.GetAllOffenses();
                    dataGridViewOffense.DataSource = offensesList;

                }
                else 
                {
                    MessageBox.Show("Neuspelo registrovanje prekrsaja");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Text != "" && textBoxVehicle.Text != "" && textBoxPoliceman.Text != "")
            {
                Offense o = new Offense();
                o.VehicleId = Convert.ToInt32(textBoxVehicle.Text);
                o.PolicemanId = Convert.ToInt32(textBoxPoliceman.Text);
                o.Date = Convert.ToDateTime(dateTimePicker.Value);
                if (this.offenseBusiness.DeleteOffense(o))
                {
                    MessageBox.Show("Uspesno brisanje prekrsaja");
                    ClearTextBox();
                    List<Offense> offensesList = this.offenseBusiness.GetAllOffenses();
                    dataGridViewOffense.DataSource = offensesList;

                }
                else
                {
                    MessageBox.Show("Neuspelo registrovanje prekrsaja");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewOffense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            dateTimePicker.Value = Convert.ToDateTime(dataGridViewOffense.Rows[row].Cells[0].Value);
            textBoxVehicle.Text = dataGridViewOffense.Rows[row].Cells[1].Value.ToString();
            textBoxPoliceman.Text = dataGridViewOffense.Rows[row].Cells[2].Value.ToString();
        }

       
    }
}
