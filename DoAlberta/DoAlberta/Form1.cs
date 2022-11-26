using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAlberta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
           

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datum1 = DateTime.Parse(maskedTextBox1.Text);
                Clovek Tonda = new Clovek(textBox6.Text, datum1);

                DateTime datum2 = DateTime.Parse(maskedTextBox2.Text);
                Clovek Hynek = new Clovek(textBox4.Text, datum2);

                label3.Text = Tonda.ToString();
                label8.Text = Hynek.ToString();
                label10.Text = Tonda.Starsi(Hynek);
                Hynek.NastavJmeno("Bedřich");
                label9.Text = "Nové jmeno: " + Hynek.VypisJmeno();
                
            }
            catch(Exception)
            {
                MessageBox.Show("Zadal jsi chybné udáje!!!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }
    }

}
