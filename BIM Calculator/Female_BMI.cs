using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM_Calculator
{
    public partial class Female_BMI : Form
    {
        public Female_BMI()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_weight.Text = "";
            txt_height.Text = "";
            txt_age.Text = "";
        }

        private void btn_calculateBMI_Click(object sender, EventArgs e)
        {
            if (txt_weight.Text != "" && txt_height.Text != "" && txt_age.Text != "")
            {
                try
                {
                    double weight = double.Parse(txt_weight.Text);
                    double height = double.Parse(txt_height.Text);
                    double age = double.Parse(txt_age.Text);

                    double bim = weight / ((height / 100) * (height / 100));

                    lbl_BMI_value.Text = bim.ToString();

                    if (bim <= 18.5)
                    {
                        lbl_status_value.Text = "UNDERWEIGHT";
                        lbl_status_value.ForeColor = Color.Cyan;
                        lbl_status_value.BackColor = Color.Black;
                    }
                    else if (bim <= 22.9)
                    {
                        lbl_status_value.Text = "NORMAL";
                        lbl_status_value.ForeColor = Color.Green;
                        lbl_status_value.BackColor = Color.Black;
                    }
                    else if (bim <= 24.9)
                    {
                        lbl_status_value.Text = "RISK TO OVERWEIGHT";
                        lbl_status_value.ForeColor = Color.Yellow;
                        lbl_status_value.BackColor = Color.Black;
                    }
                    else if (bim <= 29.9)
                    {
                        lbl_status_value.Text = "OVERWEIGHT";
                        lbl_status_value.ForeColor = Color.Orange;
                        lbl_status_value.BackColor = Color.Black;
                    }
                    else
                    {
                        lbl_status_value.Text = "OBESE";
                        lbl_status_value.ForeColor = Color.Red;
                        lbl_status_value.BackColor = Color.Black;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Enter Valid value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else
            {
                MessageBox.Show("Please enter values", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }
    }
}
