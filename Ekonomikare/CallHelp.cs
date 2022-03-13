using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Threading;

namespace Ekonomikare
{
    public partial class CallHelp : Form
    {
        private SoundPlayer music = new SoundPlayer(Properties.Resources.musicTelefon); 

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
        string aswer3 = "Ty brďo, to jsi mě zaskočil. Opravdu nevím.";
        
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
            writeAnswers();
        }

        public void playMusic()
        {
            music.Play();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                label4.Text = "Zdravím Adame, alespoň se o to pokusím";
            }
            if (progress == 3)
            {
                pictureBox3.Visible = true;
                label5.Text = "Otázka zní: " + FormHandler.main.getQuestion();
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
                button2.Visible = true;
            }
        }

        public void resCall()
        {
            button2.Visible = false;
        }

        public void generAswer()
        {

            List<Button> buttons = new List<Button>(new Button[] { FormHandler.main.getButtons(1), FormHandler.main.getButtons(2), FormHandler.main.getButtons(3), FormHandler.main.getButtons(4) });
            if (FormHandler.main.getButton5050())
            {
                if (randN >= 0 && randN < 4)
                {
                    label6.Text = aswer1 + FormHandler.main.getAnswer();
                }
                else if (randN >= 4 && randN < 7)
                {
                    if (randN2 <= 3)
                    {
                        int randN3 = r.Next(4);
                        label6.Text = aswer2 + FormHandler.main.getuCurrentAnswerOnButtonu(randN3);
                    }
                    else
                    {
                        label6.Text = aswer2 + FormHandler.main.getAnswer();
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
                    label6.Text = aswer1 + FormHandler.main.getAnswer();
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
                        label6.Text = aswer2 + FormHandler.main.getuCurrentAnswerOnButtonu(randN3);
                    }
                    else
                    {
                        label6.Text = aswer2 + FormHandler.main.getAnswer();
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
            List<string> odpo = new List<string>(new string[] { FormHandler.main.getuCurrentAnswerOnButtonu(0), FormHandler.main.getuCurrentAnswerOnButtonu(1), FormHandler.main.getuCurrentAnswerOnButtonu(2), FormHandler.main.getuCurrentAnswerOnButtonu(3) });
            List<Button> buttons = new List<Button>(new Button[] { FormHandler.main.getButtons(1), FormHandler.main.getButtons(2), FormHandler.main.getButtons(3), FormHandler.main.getButtons(4) });
            if (!FormHandler.main.get5050bool())
            {
                label7.Text = "Za A) " + FormHandler.main.getuCurrentAnswerOnButtonu(0) + " za B) " + FormHandler.main.getuCurrentAnswerOnButtonu(1) + " za C) " + FormHandler.main.getuCurrentAnswerOnButtonu(2) + " nebo za D) " + FormHandler.main.getuCurrentAnswerOnButtonu(3);
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
            button2.Visible = true;
            playMusic();
            pictureBox2.BackgroundImage = Properties.Resources.TerkaKolo1;
            pictureBox4.BackgroundImage = Properties.Resources.TerkaKolo1;
            label2.Text = "Zdravím Terezo, u telefonu Adam Skovajsa ze hry Chcete být " + FormHandler.menu.getText() + "?";
            label1.Text = "Předemnou sedí tvůj student a potřebuje tvoji pomoc. Jsi schopná mu pomoc?";
            guna2Button2.Hide();
            guna2Button1.Hide();
            panel1.Hide();
            wait6();
            for (int i = 0; i < 4; i++)
            {
                progress++;
                talk();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            playMusic();
            pictureBox2.BackgroundImage = Properties.Resources.hrdinaKolo;
            pictureBox4.BackgroundImage = Properties.Resources.hrdinaKolo;
            label2.Hide();
            button2.Visible = false;
            label2.Text = "Zdravím Zdeňku, u telefonu Adam Skovajsa ze hry Chcete být " + FormHandler.menu.getText() + "?";
            label1.Text = "Předemnou sedí tvůj student a potřebuje tvoji pomoc. Jsi schopný mu pomoc?";
            guna2Button2.Hide();
            guna2Button1.Hide();
            panel1.Hide();
            wait6();
            for(int i = 0; i < 4; i++) 
            { 
                progress++;
                talk();
            }

        }

        private void wait6()
        {
            Thread.Sleep(6000);
        }
    }
}
