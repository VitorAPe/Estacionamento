using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.Forms.DriverTypesForm
{
    public partial class FormDriverTypes : Form
    {
        public FormDriverTypes()
        {
            InitializeComponent();
        }
        private void FillGrid(string searchvalue)
        {
            string query = string.Empty;
            if (string.IsNullOrEmpty(searchvalue))
            {
                query = "select DriverTypeID [ID],DriverType[Driver Type],[Description] from DriverTypeTable";
            }
            else
            {
                query = "select DriverTypeID[ID], DriverType[Driver Type] , [Description] from DriverTypeTable  " +
                "Where(DriverType + '' + Description) like '%" + searchvalue.Trim() + "%';";
            }
            DataTable dt = DataBaseAcess.Select(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvDriverTypes.DataSource = dt;
                    dgvDriverTypes.Columns[0].Width = 100;
                    dgvDriverTypes.Columns[1].Width = 200;
                    dgvDriverTypes.Columns[2].Width = 300;
                }

            }
        }
        private void ClearForm()
        {
            txtDescription.Clear();
            txtDriverType.Clear();
            txtSearch.Clear();

        }
        private void EnableControls()
        {
            btnSave.Enabled = false;
            txtSearch.Enabled = false;
            dgvDriverTypes.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;

        }


        private void DisableControls()
        {
            btnSave.Enabled = true;
            txtSearch.Enabled = true;
            dgvDriverTypes.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            ClearForm();
            FillGrid(string.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void FormDriverTypes_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtDriverType.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDriverType, "Require field!");
                    txtDriverType.Focus();
                    return;
                }
                DataTable dt = DataBaseAcess.Select
                    ("select * from DriverTypeTable where DriverType = '" + txtDriverType.Text.Trim() + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtDriverType, "Already Exist!");
                        txtDriverType.SelectAll();
                        txtDriverType.Focus();  
                        return;
                    }
                }
                string insertquery = string.Format("Insert into DriverTypeTable(DriverType,Description)values('{0}','{1}')", txtDriverType.Text.Trim(), txtDescription.Text.Trim());
                bool result = DataBaseAcess.InsertUpdateDelete(insertquery);
                if (result == true)
                {
                    ClearForm();
                    FillGrid(string.Empty);
                    MessageBox.Show("Save Sucessfully");
                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDriverTypes.Rows.Count > 0)
            {
                if (dgvDriverTypes.SelectedRows.Count == 1)
                {
                    txtDriverType.Text = Convert.ToString(dgvDriverTypes.CurrentRow.Cells[1].Value);
                    txtDescription.Text = Convert.ToString(dgvDriverTypes.CurrentRow.Cells[2].Value);
                    EnableControls();
                }
                else
                {
                    MessageBox.Show("Please Select One Record!");

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtDriverType.Text.Trim().Length == 0)
                {
                    ep.SetError(txtDriverType, "Require field!");
                    txtDriverType.Focus();
                    return;
                }
                DataTable dt = DataBaseAcess.Select
                    ("select * from DriverTypeTable where DriverType = '" + txtDriverType.Text.Trim() + "and DriverTypeID != " + Convert.ToString(dgvDriverTypes.CurrentRow.Cells[0].Value) + "");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtDriverType, "Already Exist!");
                        txtDriverType.SelectAll();
                        txtDriverType.Focus();
                        return;
                    }
                }
                string updatequery = string.Format("Update DriverTypeTable set DriverType = '{0},Description = '{1} where DriverTypeID = '{2}')", txtDriverType.Text.Trim(), txtDescription.Text.Trim(), Convert.ToString(dgvDriverTypes.CurrentRow.Cells[0].Value));
                bool result = DataBaseAcess.InsertUpdateDelete(updatequery);
                if (result == true)
                {
                    ClearForm();
                    FillGrid(string.Empty);
                    DisableControls();
                    MessageBox.Show("Updated Sucessfully");
                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvDriverTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}