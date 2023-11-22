using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.AutoTypesForm
{
    public partial class FormAutoTypes : Form
    {
        public FormAutoTypes()
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
                    dgvAutoType.DataSource = dt;
                    dgvAutoType.Columns[0].Width = 100;
                    dgvAutoType.Columns[1].Width = 200;
                    dgvAutoType.Columns[2].Width = 300;
                }

            }
        }
        private void ClearForm()
        {
            txtDescription.Clear();
            txtAutoType.Clear();
            txtSearch.Clear();

        }
        private void EnableControls()
        {
            btnSave.Enabled = false;
            txtSearch.Enabled = false;
            dgvAutoType.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;

        }


        private void DisableControls()
        {
            btnSave.Enabled = true;
            txtSearch.Enabled = true;
            dgvAutoType.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            ClearForm();
            FillGrid(string.Empty);
        }


        private void FormAutoTypes_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                ep.Clear();
                if (txtAutoType.Text.Trim().Length == 0)
                {
                    ep.SetError(txtAutoType, "Require field!");
                    txtAutoType.Focus();
                    return;
                    
          
                }
                DataTable dt = DataBaseAcess.Select
                    ("select * from CarTypeTable where CarType = '" + txtAutoType.Text.Trim() + "'");
                
                if (dt != null)
                    
                {
                    if (dt.Rows.Count > 0)
                    {
                        
                        ep.SetError(txtAutoType, "Already Exist!");
                        txtAutoType.SelectAll();
                        txtAutoType.Focus();    
                        return;
                    }
                }
                
                string insertquery= string.Format("Insert into CarTypeTable (CarType,Description)values('{0}','{1}')", txtAutoType.Text.Trim(), txtDescription.Text.Trim());
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAutoType.Rows.Count > 0)
            {
                if (dgvAutoType.SelectedRows.Count == 1)
                {
                    txtAutoType.Text = Convert.ToString(dgvAutoType.CurrentRow.Cells[1].Value);
                    txtDescription.Text = Convert.ToString(dgvAutoType.CurrentRow.Cells[2].Value);
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
                if (txtAutoType.Text.Trim().Length == 0)
                {
                    ep.SetError(txtAutoType, "Require field!");
                    txtAutoType.Focus();
                    return;
                }
                DataTable dt = DataBaseAcess.Select
                    ("select * from CarTypeTable where CarType = '" + txtAutoType.Text.Trim() + "and CarTypeID != " + Convert.ToString(dgvAutoType.CurrentRow.Cells[0].Value) + "");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtAutoType, "Already Exist!");
                        txtAutoType.SelectAll();
                        txtAutoType.Focus();
                        return;
                    }
                }
                string updatequery = string.Format("Update CarTypeTable set CarType = '{0},Description = '{1} where CarTypeID = '{2}')", txtAutoType.Text.Trim(), txtDescription.Text.Trim(), Convert.ToString(dgvAutoType.CurrentRow.Cells[0].Value));
              
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
    }
    }


