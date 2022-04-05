using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6___Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int minimum;
        int maximum;
        double enteredNumber;
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtMin.Text, out minimum))
            {
                if (Int32.TryParse(txtMax.Text, out maximum))
                {
                    if (double.TryParse(txtNumberInput.Text, out enteredNumber))
                    {
                        if (enteredNumber > minimum && enteredNumber < maximum)
                        {
                            lblOutput.Text = ("Correct!");
                        }
                        else if (enteredNumber == minimum)
                        {
                            lblOutput.Text = ("Correct!");
                        }
                        else if (enteredNumber == maximum)
                        {
                            lblOutput.Text = ("Correct!");
                        }
                        else if (enteredNumber < minimum)
                        {
                            lblOutput.Text = ("Your Number is Too Low");
                        }
                        else if (enteredNumber > maximum)
                        {
                            lblOutput.Text = ("Your Number is Too High");
                        }
                    }
                    else
                    {
                        lblOutput.Text = ("Invalid Entry");
                    }
                }
                else
                {
                    lblOutput.Text = ("Invalid Entry");
                }
            }
            else
            {
                lblOutput.Text = ("Invalid Entry");
            }
        }

    }
}
