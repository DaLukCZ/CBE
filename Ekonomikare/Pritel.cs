using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Pritel : Form
    {
        public int pokrok = 0;
        public Pritel()
        {
            InitializeComponent();
        }

        private void Pritel_Load(object sender, EventArgs e)
        {
            label5.Text = "Otázka zní: "+FormHandler.form1.getOtazku();
            label6.Text = "Vždyť jsme se nedávno učili. Je to " + FormHandler.form1.getOdpoved();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Odpoved1_Click(object sender, EventArgs e)
        {
            pokrok++;
            Console.WriteLine(pokrok);
        }

        public void vymaz() {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        public void konverzuj() {
            if (pokrok == 1) {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            if (pokrok == 2) {
                pictureBox2.Visible = true;
                label4.Visible = true;
            }
            if (pokrok == 3) { 
                pictureBox3.Visible = true;
                label5.Visible = true;
            }
            if (pokrok == 4) { 
                pictureBox4.Visible = true;
                label6.Visible = true;
            }
        }
    }
}
