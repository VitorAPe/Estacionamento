using Estacionamento.AutoTypesForm;
using Estacionamento.Forms.DriverTypesForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbtnDriverTypes_Click(object sender, EventArgs e)
        {
          FormDriverTypes DriverTypesForm =new FormDriverTypes();
            DriverTypesForm.ShowDialog();
        }

        private void tbstnCarTypes_Click(object sender, EventArgs e)
        {
            FormAutoTypes AutoTypeForm = new FormAutoTypes();
            AutoTypeForm.ShowDialog();
        }
    }
}
