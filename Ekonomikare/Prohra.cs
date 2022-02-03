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
    public partial class Prohra : Form
    {
        public Prohra()
        {
            InitializeComponent();
        }

        private void Prohra_Load(object sender, EventArgs e)
        {
            label3.Text = "Zprávná odpověď byla " +FormHandler.form1.getOdpoved() +".";
        }

        private void button_Odpoved1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHandler.form1.restart();
            this.Close();
        }
    }
}
