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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_male_Click(object sender, EventArgs e)
        {
            Male_BMI male_BMI = new Male_BMI();
            male_BMI.Show();
            
        }

        private void btn_female_Click(object sender, EventArgs e)
        {
            Female_BMI female_BMI = new Female_BMI();
            female_BMI.Show();
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
