using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Ekonomikare
{
    public partial class CallHelp : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        Random r = new Random();
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
            }
            if (progress == 2)
            {
                pictureBox2.Visible = true;
                label4.Visible = true;
                label4.Text = "Ahoj Adame, jasně ptej se";
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
                        label6.Text = aswer2 + FormHandler.form1.getuCurrentAnswerOnButtonu(randN3);
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
                        label6.Text = aswer2 + FormHandler.form1.getuCurrentAnswerOnButtonu(randN3);
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


        private void writeAnswers()
        {
            List<string> odpo = new List<string>(new string[] { FormHandler.form1.getuCurrentAnswerOnButtonu(0), FormHandler.form1.getuCurrentAnswerOnButtonu(1), FormHandler.form1.getuCurrentAnswerOnButtonu(2), FormHandler.form1.getuCurrentAnswerOnButtonu(3) });
            List<Button> buttons = new List<Button>(new Button[] { FormHandler.form1.getButtons(1), FormHandler.form1.getButtons(2), FormHandler.form1.getButtons(3), FormHandler.form1.getButtons(4) });
            if (!FormHandler.form1.get5050bool())
            {
                label7.Text = "Za A) " + FormHandler.form1.getuCurrentAnswerOnButtonu(0) + " za B) " + FormHandler.form1.getuCurrentAnswerOnButtonu(1) + " za C) " + FormHandler.form1.getuCurrentAnswerOnButtonu(2) + " nebo za D) " + FormHandler.form1.getuCurrentAnswerOnButtonu(3);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.TerkaKolo;
            pictureBox4.BackgroundImage = Properties.Resources.TerkaKolo;
            button1.Visible = true;
            label2.Text = "Ahoj Terko, dali mi za úkol uvádět nějakou hovadinu s otázkami.";
            label1.Text = "Poradíš mu, protože já žeprý nemůžu?";
            FormHandler.form1.callHelpDis();
            guna2Button2.Hide();
            guna2Button1.Hide();
            panel1.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.hrdinaKolo;
            pictureBox4.BackgroundImage = Properties.Resources.hrdinaKolo;
            label2.Hide();
            button1.Visible = true;
            label2.Text = "Ahoj Zdeňo, dali mi za úkol uvádět nějakou hovadinu s otázkami.";
            label1.Text = "Poradíš mu, protože já žeprý nemůžu?";
            FormHandler.form1.callHelpDis();
            guna2Button2.Hide();
            guna2Button1.Hide();
            panel1.Hide();
        }
    }

}
