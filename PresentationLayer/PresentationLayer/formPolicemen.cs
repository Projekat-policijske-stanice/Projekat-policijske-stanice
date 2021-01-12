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
    public partial class formPolicemen : Form
    {
        private readonly IPolicemanBusiness policemanBusiness;
        public formPolicemen(IPolicemanBusiness _policemanBusiness)
        {
            InitializeComponent();
            this.policemanBusiness = _policemanBusiness;
        }
        private void frmPolicemen_Load(object sender, EventArgs e)
        {
            List<Policeman> policemanList = this.policemanBusiness.GetAllPolicemen();
            dataGridPolicemen.DataSource = policemanList;
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxJMBG.Text != "" && textBoxShift.Text != "" && comboBoxStatus.Text != "" && comboBoxGender.Text != "")
            {
                Policeman p = new Policeman();
                p.Id = int.Parse(textBoxId.Text);
                p.Name = textBoxName.Text;
                p.Surname = textBoxSurname.Text;
                p.JMBG = textBoxJMBG.Text;
                p.Shift = textBoxShift.Text;
                p.Status = comboBoxStatus.Text;
                p.Gender = comboBoxGender.Text;

                if (this.policemanBusiness.UpdatePoliceman(p))
                {
                    MessageBox.Show("Uspesno izmenjen policajac");
                    ClearTextBox();
                    List<Policeman> policemanList = this.policemanBusiness.GetAllPolicemen();
                    dataGridPolicemen.DataSource = policemanList;
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni policajca");
                }
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxJMBG.Text = "";
            textBoxShift.Text = "";
            comboBoxStatus.SelectedIndex = -1;
            comboBoxGender.SelectedIndex = -1;
        }
        private void dataGridPolicemen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBoxId.Text = dataGridPolicemen.Rows[row].Cells[0].Value.ToString();
            textBoxName.Text = dataGridPolicemen.Rows[row].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridPolicemen.Rows[row].Cells[2].Value.ToString();
            textBoxJMBG.Text = dataGridPolicemen.Rows[row].Cells[3].Value.ToString();
            textBoxShift.Text = dataGridPolicemen.Rows[row].Cells[4].Value.ToString();
            comboBoxStatus.Text = dataGridPolicemen.Rows[row].Cells[5].Value.ToString();
            comboBoxGender.Text = dataGridPolicemen.Rows[row].Cells[6].Value.ToString();
        }

        private void buttondAdd_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxJMBG.Text != "" && textBoxShift.Text != "" && comboBoxStatus.Text != "" && comboBoxGender.Text != "")
            {
                Policeman p = new Policeman();
                p.Name = textBoxName.Text;
                p.Surname = textBoxSurname.Text;
                p.JMBG = textBoxJMBG.Text;
                p.Shift = textBoxShift.Text;
                p.Status = comboBoxStatus.Text;
                p.Gender = comboBoxGender.Text;

                if (this.policemanBusiness.InsertPoliceman(p))
                {
                    MessageBox.Show("Uspesno dodat policajac");
                    ClearTextBox();
                    List<Policeman> policemanList = this.policemanBusiness.GetAllPolicemen();
                    dataGridPolicemen.DataSource = policemanList;
                }
                else
                {
                    MessageBox.Show("Greska pri dodavanju policajca");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (textBoxId.Text != "")
            {
                int idDelete = Convert.ToInt32(textBoxId.Text);
                if (this.policemanBusiness.DeletePoliceman(idDelete))
                {
                    MessageBox.Show("Uspesno obrisan policajac");
                    ClearTextBox();
                    List<Policeman> policemanList = this.policemanBusiness.GetAllPolicemen();
                    dataGridPolicemen.DataSource = policemanList;
                }
                else
                {
                    MessageBox.Show("Greska pri brisanju policajca");
                }
            }
        }

       
    }
}
