using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int cOne, cTwo, cThree, cFour, cFive;

            cOne = int.Parse(txtOne.Text);
            cTwo = int.Parse(txtTwo.Text);
            cThree = int.Parse(txtThree.Text);
            cFour = int.Parse(txtFour.Text);
            cFive = int.Parse(txtFive.Text);

            int sum = cOne + cTwo + cThree + cFour + cFive;
            int dozens;
            int remainder = 0; dozens = 0;
            if (sum % 12 == 0)
            {
                dozens = sum / 12;
            }
            else {

                dozens = (int)sum / 12;
                remainder = sum - (dozens * 12);
            
            }

            rtbOutput.Text = "a total of "+ sum+" eggs is " + dozens.ToString() + " dosens and "+ remainder+" eggs";
                ;

        }
    }
}
