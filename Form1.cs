using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge04_577669
{
    public partial class Form1 : Form
    {
        public int scCount=0;
        public int nvCount=0;
        public int lower, upper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            
            //Condition 1: Length
            int passLength = txtPassword.Text.Length;

            if (passLength < 8)
            {
                cbLength.Checked = false;
            }
            else
            {
                cbLength.Checked = true;
            }

            //Condition 2:UpperCase & Lowercase
            
            foreach (char c in pass)
            {
                if (Char.IsLower(c))
                {
                    lower = 1;
                }
                else if (Char.IsUpper(c))
                {
                    upper=2;
                }
            }

            if ((lower==1)&&(upper==2))
            {
                cbCase.Checked = true;
            }
            else
            {
                cbCase.Checked = false;
            }

            //Condition 3: Numeric Value
            if (pass.Any(char.IsDigit))
            {
                nvCount++;
            }
            else
            {
                nvCount = 0;
            }

            if (nvCount >= 1)
            {
                cbNum.Checked = true;
            }
            else
            {
                cbNum.Checked = false;
            }

            //Condition 4: Special Character
            foreach (char c in pass)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                  scCount++;
                }
            }
            if (scCount >= 1)
            {
                cbSpecial.Checked = true;
            }
            else
            {
                cbSpecial.Checked = false;
            }

            //Condition 5: No Space
            if (pass.Contains(" "))
            {
                cbSpace.Checked = false;
            }
            else
            {
                cbSpace.Checked = true;
            }
            
            buttonShow();
            passStrength();
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            
        }

        private void pbShow_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        public void buttonShow()
        {
            if ((cbLength.Checked == true) && (cbCase.Checked == true) && (cbNum.Checked == true) && (cbSpecial.Checked == true) && (cbSpace.Checked == true))
            {
                btnSubmit.Enabled = true;
            }
        }

        public void reset()
        {
            txtPassword.Text = "";

            cbLength.Checked = false;
            cbCase.Checked = false;
            cbNum.Checked = false;
            cbSpecial.Checked = false;
            cbSpace.Checked = false;

            lblStrength.Text = "Password Strength: ";
        }
        public void passStrength()
        {
            //Passowrd Strenth
            if ((cbLength.Checked == true) && (cbCase.Checked == true) && (cbNum.Checked == true) && (cbSpecial.Checked == true) && (cbSpace.Checked == true))
            {
                lblStrength.Text = "Password Strength: Strong";
            }
            else if ((cbLength.Checked == true) && (cbSpecial.Checked == true) && (cbNum.Checked == true))
            {
                lblStrength.Text = "Password Strength: Moderate";
            }
            else
            {
                lblStrength.Text = "Password Strength: Weak";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well done!!That's a STRONG password you got there");
            reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
