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
    public partial class Form2 : Form
    {
        public Form2()
        {
            Form1 form1 = new Form1();
            InitializeComponent();
            form1.Visible = false;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: dodělej tlačítko pro vypnutí programu
            //je nutno udělat podmínku v program.cs
            //form1 se vytvoří, jen, když button 1 je click
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Visible = true;
        }
    }
}
