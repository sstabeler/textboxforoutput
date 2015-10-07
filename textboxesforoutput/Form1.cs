using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace textboxesforoutput
{
    public partial class textboxesforoutput : Form
    {
        public textboxesforoutput()
        {
            InitializeComponent();
        }

        private void btnFormat_MouseClick(object sender, MouseEventArgs e)
        {
            decimal decInput;

            decInput = Convert.ToDecimal(txtboxInput.Text);

            txtboxoutput.Text = decInput.ToString();

            txtCurrency.Text = decInput.ToString("c", System.Globalization.CultureInfo.CurrentUICulture);

        }
    }
}
