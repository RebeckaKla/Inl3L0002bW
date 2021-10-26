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
            person.ktr21(pnr);
        }
        public class person
        {
            string name;
            string last_name;
            string pnr;

            public static double ktr21(string pnr) // Denna metod avgör om personnumret är korrekt
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
                if (svar == 0) // Om svaret är lika med noll kan vi avgöra att personnumret stämmer
                {
                    MessageBox.Show("Personnummer stämmer");
                    female_male(pnr); // Eftersom personnumret stämmer går programmet vidare och kör nästa metod som avgör vilket kön användaren har
                }
                if (svar != 0) // Om svaret inte är lika med noll  så stämmer inte personnumret och programmet kallar inte metoden female_male
                {
                    MessageBox.Show("Personnummer stämmer inte");
                }
                return (value % 10);
            }

            static void female_male(string pnr) // Denna metod avgör vilket kön användaren har baserat på den näst sista siffran i personnumret
            {

                int gender = pnr[8] - 48; // Genom denna variabel markerar man vilken siffra som metoden ska använda sig av för att sedan användas inom if-satsen
                if ((gender == 1) || (gender == 3) || (gender == 5) || (gender == 7) || (gender == 9)) // De udda siffrorna visar att personen är en man
                {

                    MessageBox.Show("Man");
                }
                if ((gender == 0) || (gender == 2) || (gender == 4) || (gender == 6) || (gender == 8))// De jämna siffrorna visar att personen är en kvinnna 
                {
                    MessageBox.Show("Kvinna");
                }
            }
        }


    }
}
