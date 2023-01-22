using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashin_hesab_T3ohid
{
    public partial class Form1 : Form
    {
        IRole mashin_hesab;
        public Form1()
        {
            InitializeComponent();
            mashin_hesab = new Masihn_Hesab(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        bool ValidateInput()
        {
            bool isValid = true;

            if (num1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");

            }
            else
            {
                if (num2.Value == 0) 
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
               
                }
            }
            return isValid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = mashin_hesab.jame((int)num1.Value, (int)num2.Value);
                MessageBox.Show("sum is " + sum);
            }
            
        }
        private void btnkam_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = mashin_hesab.tafrig((int)num1.Value, (int)num2.Value);
                MessageBox.Show("sum is " + sum);
            }
        }

        private void btnzarb_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = mashin_hesab.zarb((int)num1.Value, (int)num2.Value);
                MessageBox.Show("sum is " + sum);
            }
        }

        private void btntagsim_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = mashin_hesab.tagsim((int)num1.Value, (int)num2.Value);
                MessageBox.Show("sum is " + sum);
            } 
        }
    }
}
