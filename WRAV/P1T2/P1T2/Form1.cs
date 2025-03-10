using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P1T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txtRadius.Text);
            double circumference = 2 * Math.PI * radius;
            double areaCircle = Math.PI * (radius * radius);
            double areaSphere = 4 * Math.PI * (radius * radius);

            if (cmbChoice.SelectedIndex == 0)
            {
                lblAnswer.Text = circumference.ToString();
            }
            else if (cmbChoice.SelectedIndex == 1)
            {
                lblAnswer.Text = areaCircle.ToString() ;
            }
            else if (cmbChoice.SelectedIndex == 2) {
                lblAnswer.Text = areaSphere.ToString();
            
            }
        }
    }
}
