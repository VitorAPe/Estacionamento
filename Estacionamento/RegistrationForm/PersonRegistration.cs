using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.RegistrationForm
{
    public partial class txtContactNo : Form
    {
        public txtContactNo()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            string query = string.Empty;
            if (string.IsNullOrEmpty(searchvalue))
            {
                query = "select CarTypeID [ID],CarType [Auto Type],[Description] from CarTypeTable";
            }
            else
            {
                query = "select CarTypeID[ID], CarType [Auto Type] , [Description] from CarTypeTable  " +
                "Where(CarType + '' + Description) like '%" + searchvalue.Trim() + "%';";
            }
            DataTable dt = DataBaseAcess.Select(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)  
                {
                    dgvPersonList.DataSource = dt;
                    dgvPersonList.Columns[0].Width = 100;
                    dgvPersonList.Columns[1].Width = 200;
                    dgvPersonList.Columns[2].Width = 300;
                }

            }
        }
        private void ClearForm()
        {
            txtDescription.Clear();
           // txtAutoType.Clear();
            txtSearch.Clear();

        }
        private void EnableControls()
        {
            btnSave.Enabled = false;
            txtSearch.Enabled = false;
            dgvPersonList.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;

        }


        private void DisableControls()
        {
            btnSave.Enabled = true;
            txtSearch.Enabled = true;
            dgvPersonList.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            ClearForm();
            FillGrid(string.Empty);
        }

        private void PersonRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
