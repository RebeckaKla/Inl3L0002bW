using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L0002bInl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Denna knapp aktiverar metoderna ktr21 samt Female_male samt ber användaren om input
        {
            string name = textBox1.Text;
            string last_name = textBox2.Text;
            string pnr = textBox3.Text;
            
        }
        static double ktr21(string pnr)
        {
            int value = 0;
            for (int i = 0; i < pnr.Length; i++)
            {
                int t = (pnr[i] - 48)
                    << (1 - (i & 1));
                if (t > 9)
                    t = t - 9;
                value += t;

            }

            int svar = value % 10;
            if (svar == 0)
            {
                MessageBox.Show("Personnummer stämmer");
                female_male(pnr);
            }
            if (svar != 0)
            {
                MessageBox.Show("Personnummer stämmer inte");
            }
            return (value % 10);
        }

        static void female_male(string pnr)
        {

            int gender = pnr[8] - 48;
            if ((gender == 1) || (gender == 3) || (gender == 5) || (gender == 7) || (gender == 9))
            {

                MessageBox.Show("Man");
            }
            if ((gender == 0) || (gender == 2) || (gender == 4) || (gender == 6) || (gender == 8))
            {
                MessageBox.Show("Kvinna");
            }
        }
    }
}
