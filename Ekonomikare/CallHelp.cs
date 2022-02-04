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
    public partial class CallHelp : Form
    {
        Random r = new Random();
        //List<string> aswers = new List<string>(new string[] { "Vždyť jsme se nedávno učili. Je to", "Ty brďo, to jste mě zaskočil. Opravdu nevím" });
        string aswer1 = "Vždyť jsme se nedávno učili. Je to ";
        string aswer2 = "Ty brďo, nevím přesně, ale asi ";
        string aswer3 = "Ty brďo, to jste mě zaskočil. Opravdu nevím.";
        //string aswer1 = "Vždyť jsme se nedávno učili. Je to ";
        int randN;
        public int progress = 0;
        public CallHelp()
        {
            InitializeComponent();
        }

        private void CallHelp_Load(object sender, EventArgs e)
        {
            clear();
            randN = r.Next(10);
            Console.WriteLine(randN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
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
        public void talk()
        {
            if (progress == 1)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            if (progress == 2)
            {
                pictureBox2.Visible = true;
                label4.Visible = true;
            }
            if (progress == 3)
            {
                pictureBox3.Visible = true;
                label5.Text = "Otázka zní: " + FormHandler.form1.getQuestion();
                label5.Visible = true;
            }
            if (progress == 4)
            {
                pictureBox4.Visible = true;
                generAswer();
                label6.Visible = true;
            }
            if (progress >= 4) {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progress++;
            talk();
        }

        public void generAswer() {
            if (randN >= 0 && randN < 5)
            {
                label6.Text = aswer1 + FormHandler.form1.getAnswer();
            }
            else if (randN >= 5 && randN < 7)
            {
                label6.Text = aswer2 + FormHandler.form1.getAnswer();
            }
            else {
                label6.Text = aswer3;
            }
        }
    }
}
