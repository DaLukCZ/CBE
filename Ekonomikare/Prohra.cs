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
        Form1 form1 = new Form1();
        public Prohra()
        {
            InitializeComponent();
        }

        private void Prohra_Load(object sender, EventArgs e)
        {

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
            this.Close();
            
            Form2 form2 = new Form2();
            form1.Visible = false;
            form2.Show();
        }
    }
}
