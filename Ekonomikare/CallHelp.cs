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

namespace Chcete_byt_EXPERTEM
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

        public int getSizeW()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            decimal screenWidthPercent = (decimal)screenWidth / 1920 * 100;
            return (int)screenWidthPercent;
        }

        public int getSizeH()
        {
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            decimal screenHeightPercent = (decimal)screenHeight / 1080 * 100;
            return (int)screenHeightPercent;
        }

        public void Calibration()
        {
            int Width = getSizeW();
            int Height = getSizeH();

            pictureBox1.Size = new Size((131 * Width) / 100, (120 * Height) / 100);
            pictureBox1.Location = new Point((76 * Width) / 100, (54 * Height) / 100);

            pictureBox2.Size = new Size((131 * Width) / 100, (120 * Height) / 100);
            pictureBox2.Location = new Point((76 * Width) / 100, (209 * Height) / 100);

            pictureBox3.Size = new Size((131 * Width) / 100, (120 * Height) / 100);
            pictureBox3.Location = new Point((76 * Width) / 100, (375 * Height) / 100);

            pictureBox4.Size = new Size((131 * Width) / 100, (120 * Height) / 100);
            pictureBox4.Location = new Point((76 * Width) / 100, (533 * Height) / 100);

            panel1.Size = new Size((330 * Width) / 100, (596 * Height) / 100);
            panel1.Location = new Point((420 * Width) / 100, (57 * Height) / 100);

            guna2Button1.Size = new Size((281 * Width) / 100, (270 * Height) / 100);
            guna2Button1.Location = new Point((24 * Width) / 100, (308 * Height) / 100);

            guna2Button2.Size = new Size((281 * Width) / 100, (270 * Height) / 100);
            guna2Button2.Location = new Point((24 * Width) / 100, (36 * Height) / 100);

            button2.Size = new Size((212 * Width) / 100, (95 * Height) / 100);
            button2.Location = new Point((875 * Width) / 100, (558 * Height) / 100);
            button2.Font = new Font(button2.Font.Name, (22 * Width) / 100, button2.Font.Style);

            label2.Size = new Size((862 * Width) / 100, (50 * Height) / 100);
            label2.Location = new Point((225 * Width) / 100, (70 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (18 * Width) / 100, label2.Font.Style);

            label1.Size = new Size((862 * Width) / 100, (50 * Height) / 100);
            label1.Location = new Point((225 * Width) / 100, (112 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (18 * Width) / 100, label1.Font.Style);

            label4.Size = new Size((862 * Width) / 100, (120 * Height) / 100);
            label4.Location = new Point((225 * Width) / 100, (209 * Height) / 100);
            label4.Font = new Font(label4.Font.Name, (18 * Width) / 100, label4.Font.Style);

            label5.Size = new Size((862 * Width) / 100, (50 * Height) / 100);
            label5.Location = new Point((225 * Width) / 100, (387 * Height) / 100);
            label5.Font = new Font(label5.Font.Name, (18 * Width) / 100, label5.Font.Style);

            label7.Size = new Size((862 * Width) / 100, (70 * Height) / 100);
            label7.Location = new Point((225 * Width) / 100, (425 * Height) / 100);
            label7.Font = new Font(label7.Font.Name, (18 * Width) / 100, label7.Font.Style);

            label6.Size = new Size((644 * Width) / 100, (112 * Height) / 100);
            label6.Location = new Point((225 * Width) / 100, (533 * Height) / 100);
            label6.Font = new Font(label6.Font.Name, (18 * Width) / 100, label6.Font.Style);

            this.Size = new Size((1149 * Width) / 100, (711 * Height) / 100);
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
            Calibration();
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
                label4.Text = "Zdravím Adame, jasně ptej se.";
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
            label1.Text = "Předemnou sedí tvůj žák a potřebuje tvoji pomoc. Jsi schopná mu pomoci?";
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
            label1.Text = "Předemnou sedí tvůj žák a potřebuje tvoji pomoc. Jsi schopný mu pomoci?";
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
