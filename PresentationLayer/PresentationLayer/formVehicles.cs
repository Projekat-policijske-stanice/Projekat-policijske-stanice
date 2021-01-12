using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
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
    public partial class formVehicles : Form
    {
        private readonly IVehicleBusiness vehicleBusiness;
        public formVehicles(IVehicleBusiness _vehicleBusiness)
        {
            InitializeComponent();
            this.vehicleBusiness = _vehicleBusiness;
        }
        private void formVehicles_Load(object sender, EventArgs e)
        {
            List<Vehicle> vehiclesList = this.vehicleBusiness.GetAllVehicles();
            dataGridVehicles.DataSource = vehiclesList;
            dataGridVehicles.Columns["Name"].Width = 150;
            dataGridVehicles.Columns["Consumption"].Width = 50;
            dataGridVehicles.Columns["Condition"].Width = 150;
            dataGridVehicles.Columns["Correctness"].Width = 150;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxType.Text = "";
            textBoxConsumption.Text = "";
            textBoxCorrectness.Text = "";
            comboBoxCondition.SelectedIndex = -1;
        }
        private void dataGridVozila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBoxId.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[0].Value);
            textBoxName.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[1].Value);
            textBoxType.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[2].Value);
            textBoxConsumption.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[3].Value);
            textBoxCorrectness.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[4].Value);
            comboBoxCondition.Text = Convert.ToString(dataGridVehicles.Rows[row].Cells[5].Value);
        }
        private void buttondAdd_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxType.Text != "" && textBoxConsumption.Text != "" && textBoxCorrectness.Text != "" && comboBoxCondition.Text != "")
            {
                Vehicle v = new Vehicle();
                v.Name = textBoxName.Text;
                v.Type = textBoxType.Text;
                v.Consumption = Convert.ToDecimal(textBoxConsumption.Text);
                v.Correctness = textBoxCorrectness.Text;
                v.Condition = comboBoxCondition.Text;

                if (this.vehicleBusiness.InsertVehicle(v))
                {
                    MessageBox.Show("Uspesno dodato vozilo");
                    ClearTextBox();
                    List<Vehicle> vehiclesList = this.vehicleBusiness.GetAllVehicles();
                    dataGridVehicles.DataSource = vehiclesList;
                }
                else
                {
                    MessageBox.Show("Greska pri dodavanju vozila");
                }
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxType.Text != "" && textBoxConsumption.Text != "" && textBoxCorrectness.Text != "" && comboBoxCondition.Text != "")
            {
                Vehicle v = new Vehicle();
                v.Id = Convert.ToInt32(textBoxId.Text);
                v.Name = textBoxName.Text;
                v.Type = textBoxType.Text;
                v.Consumption = Convert.ToDecimal(textBoxConsumption.Text);
                v.Correctness = textBoxCorrectness.Text;
                v.Condition = comboBoxCondition.Text;

                if (this.vehicleBusiness.UpdateVehicle(v))
                {
                    MessageBox.Show("Uspesno izmenjeno vozilo");
                    ClearTextBox();
                    List<Vehicle> vehiclesList = this.vehicleBusiness.GetAllVehicles();
                    dataGridVehicles.DataSource = vehiclesList;
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni vozila");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                int idDelete = Convert.ToInt32(textBoxId.Text);

                if (this.vehicleBusiness.DeleteVehicle(idDelete))
                {
                    MessageBox.Show("Uspesno obrisano vozilo");
                    ClearTextBox();
                    List<Vehicle> vehiclesList = this.vehicleBusiness.GetAllVehicles();
                    dataGridVehicles.DataSource = vehiclesList;
                }
                else
                {
                    MessageBox.Show("Greska pri brisanju vozila");
                }
            }
        }

       
    }
}
