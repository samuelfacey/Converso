using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converso
{
    public static class Methods
    {
        public static void UpdateText(ComboBox cmbModeSelect, TextBox txtBoxInput, TextBox txtBoxOutput)
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
    }
}
