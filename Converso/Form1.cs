using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbModeSelect.Text = "Keep Input";
        }

        private void btnCallAPI_Click(object sender, EventArgs e)
        {

            if (cmbModeSelect.Text == "Keep Input")
            {
                txtBoxOutput.Text = txtBoxInput.Text;
            }
            else
            {
                txtBoxOutput.Text = txtBoxInput.Text;
                txtBoxInput.Clear();
            }

        }

        private void cmbModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
