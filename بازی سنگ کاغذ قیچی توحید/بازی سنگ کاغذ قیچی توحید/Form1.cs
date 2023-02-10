using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace بازی_سنگ_کاغذ_قیچی_توحید
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             
            InitializeComponent();
        }
        private void geychi_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int compchoise;
            ChosePlayer.Text = "انتخاب شما : " + "قیچی";
            int randnum = rand.Next(100, 4000);
            compchoise = (randnum % 3) + 1;
            switch (compchoise)
            {
                case 1:
                    ChoseBot.Text = "انتخاب ربات : " + "قیچی";
                    lblwin.Text = "بازی مساوری شد";
                    break;
                case 2:
                    ChoseBot.Text = "انتخاب ربات : " + "سنگ";
                    lblwin.Text = "بازیکن بازنده شد";

                    break;
                case 3:
                    ChoseBot.Text = "انتخاب ربات : " + "کاغذ";
                    lblwin.Text = "بازیکن برنده شد";
                    break;

            }
        }

        private void kagaz_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int compchoise;
            ChosePlayer.Text = "انتخاب شما : " + "کاغذ";
            int randnum = rand.Next(100, 4000);
            compchoise = (randnum % 3) + 1;
            switch (compchoise)
            {
                case 1:
                    ChoseBot.Text = "انتخاب ربات : " + "کاغذ";
                    lblwin.Text = "بازی مساوری شد";
                    break;
                case 2:
                    ChoseBot.Text = "انتخاب ربات : " + "قیچی";
                    lblwin.Text = "بازیکن بازنده شد";
                    break;
                case 3:
                    ChoseBot.Text = "انتخاب ربات : " + "سنگ";
                    lblwin.Text = "بازیکن برنده شد";
                    break;

            }
        }

        private void sanj_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int compchoise;
            ChosePlayer.Text = "انتخاب شما : " + "سنگ";
            int randnum = rand.Next(100, 4000);
            compchoise = (randnum % 3) + 1;
            switch (compchoise)
            {
                case 1:
                    ChoseBot.Text = "انتخاب ربات : " + "سنگ";
                    lblwin.Text = "بازی مساوری شد";
                    break;
                case 2:
                    ChoseBot.Text = "انتخاب ربات : " + "کاغذ";
                    lblwin.Text = "بازیکن بازنده شد";
                    break;
                case 3:
                    ChoseBot.Text = "انتخاب ربات : " + "قیچی";
                    lblwin.Text = "بازیکن برنده شد";
                    break;

            }
        }
    }
}
