using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Form2 : Form
    {
        //parametry
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
