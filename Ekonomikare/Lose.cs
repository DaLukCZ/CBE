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
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            label3.Text = "Správná odpověď byla " + FormHandler.form1.getAnswer() + ".";
            label_pocet.Text = "" + FormHandler.form1.getStep() + " / 10";
        }

        private void button_Answer1_Click(object sender, EventArgs e)
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

        private void button_Menu_Click(object sender, EventArgs e)
        {
            FormHandler.form2.Show();
            FormHandler.form1.Hide();
            this.Hide();
        }
    }
}
