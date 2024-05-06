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
            timer1.Enabled = false;
        }

        private void btnCallAPI_Click(object sender, EventArgs e)
        {
            Methods.UpdateText(cmbModeSelect, txtBoxInput, txtBoxOutput);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Methods.UpdateText(cmbModeSelect, txtBoxInput, txtBoxOutput);
        }

        private void checkTimer1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTimer1.Checked)
            {
                timer1.Enabled = true;
            }
            else
            { 
                timer1.Enabled = false;
            }
        }
    }
}
