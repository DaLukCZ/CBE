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
        string TerHello = "Dobrý večer, manžel mi o vás hodně vyprávěl. Jasně, ptejte se.";
        string SkovyHello = "Dobrý večer, kolego, jasně.";
        string aswer1 = "Vždyť jsme se nedávno učili. Je to ";
        string aswer2 = "Ty brďo, nevím přesně, ale asi ";
        string aswer3 = "Ty brďo, to jste mě zaskočil. Opravdu nevím.";
        string call;
        int randN;
        int randN2;
        public int progress = 0;
        public CallHelp()
        {
            InitializeComponent();
        }

        private void CallHelp_Load(object sender, EventArgs e)
        {
            clear();
            randN = r.Next(10);
            randN2 = r.Next(10);
            button1.Visible = false;
            button2.Visible = true;
            Console.WriteLine(randN2);
            writeAnswers();
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
            label7.Visible = false;
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
                label7.Visible = true;
            }
            if (progress == 4)
            {
                pictureBox4.Visible = true;
                generAswer();
                label6.Visible = true;
            }
            if (progress >= 4)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progress++;
            talk();
        }

        public void generAswer()
        {

            List<Button> buttons = new List<Button>(new Button[] { FormHandler.form1.getButtons(1), FormHandler.form1.getButtons(2), FormHandler.form1.getButtons(3), FormHandler.form1.getButtons(4) });
            if (FormHandler.form1.getButton5050())
            {
                if (randN >= 0 && randN < 4)
                {
                    label6.Text = aswer1 + FormHandler.form1.getAnswer();
                }
                else if (randN >= 4 && randN < 7)
                {
                    if (randN2 <= 3)
                    {
                        int randN3 = r.Next(4);
                        label6.Text = aswer2 + FormHandler.form1.getRandomAnswer(randN3);
                    }
                    else
                    {
                        label6.Text = aswer2 + FormHandler.form1.getAnswer();
                    }
                }
                else
                {
                    label6.Text = aswer3;
                }
            }
            else
            {
                if (randN >= 0 && randN < 4)
                {
                    label6.Text = aswer1 + FormHandler.form1.getAnswer();
                }
                else if (randN >= 4 && randN < 7)
                {
                    if (randN2 < 4)
                    {
                        int randN3 = r.Next(4);
                        while (!buttons[randN3].Enabled)
                        {
                            randN3 = r.Next(4);
                        }
                        label6.Text = aswer2 + FormHandler.form1.getRandomAnswer(randN3);
                    }
                    else
                    {
                        label6.Text = aswer2 + FormHandler.form1.getAnswer();
                    }
                }
                else
                {
                    label6.Text = aswer3;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.skovy;
            pictureBox4.BackgroundImage = Properties.Resources.skovy;
            button3.Hide();
            button4.Hide();
            button1.Visible = true;
            label4.Text = SkovyHello;
            call = "pane učiteli Skovajso";
            label2.Text = "Dobrý večer, " + call + ",  u telefonu Adam Skovajsa z pořadu Chcete být";
            FormHandler.form1.callHelpDis();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.ohno;
            pictureBox4.BackgroundImage = Properties.Resources.ohno;
            button3.Hide();
            button4.Hide();
            button1.Visible = true;
            label4.Text = TerHello;
            call = "paní učitelko Přikrylová";
            label2.Text = "Dobrý večer, " + call + ",  u telefonu Adam Skovajsa z pořadu Chcete být";
            FormHandler.form1.callHelpDis();

        }

        private void writeAnswers()
        {
            string od1 = FormHandler.form1.getRandomAnswer(0);
            string od2 = FormHandler.form1.getRandomAnswer(1);
            string od3 = FormHandler.form1.getRandomAnswer(2);
            string od4 = FormHandler.form1.getRandomAnswer(3);
            //List<Guna.UI2.WinForms.Guna2Button> buttonsG = new List<Guna.UI2.WinForms.Guna2Button>(new Guna.UI2.WinForms.Guna2Button[] { guna2Button1 });

            List<string> odpo = new List<string>(new string[] { od1, od2, od3, od4 });
            List<Button> buttons = new List<Button>(new Button[] { FormHandler.form1.getButtons(1), FormHandler.form1.getButtons(2), FormHandler.form1.getButtons(3), FormHandler.form1.getButtons(4) });
            if (FormHandler.form1.getButton5050())
            {
                label7.Text = "Za A) " + FormHandler.form1.getRandomAnswer(0) + " za B) " + FormHandler.form1.getRandomAnswer(1) + " za C) " + FormHandler.form1.getRandomAnswer(2) + " nebo za D) " + FormHandler.form1.getRandomAnswer(3);
            }
            else
            {
                string celaOtaz = "";
                int p = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (buttons[i].Enabled)
                    {
                        if (p == 1)
                        {
                            celaOtaz += " nebo ";
                        }
                        p++;
                        celaOtaz += odpo[i];
                    }
                }
                label7.Text = celaOtaz;
            }
        }
    }

}
