using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    public partial class Victory : Form
    {

        private SoundPlayer music = new SoundPlayer(Properties.Resources.musicVictory);
        public Victory()
        {
            InitializeComponent();
            transparent();
            Calibration();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
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

            NameObor.Size = new Size((565 * Width) / 100, (80 * Height) / 100);
            NameObor.Location = new Point((682 * Width) / 100, (198 * Height) / 100);
            NameObor.Font = new Font(NameObor.Font.Name, (34 * Width) / 100, NameObor.Font.Style);

            label1.Size = new Size((616 * Width) / 100, (126 * Height) / 100);
            label1.Location = new Point((12 * Width) / 100, (198 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (80 * Width) / 100, label1.Font.Style);

            label_obor.Size = new Size((596 * Width) / 100, (45 * Height) / 100);
            label_obor.Location = new Point((148 * Width) / 100, (375 * Height) / 100);
            label_obor.Font = new Font(label_obor.Font.Name, (28 * Width) / 100, label_obor.Font.Style);

            label_spravne.Size = new Size((689 * Width) / 100, (45 * Height) / 100);
            label_spravne.Location = new Point((110 * Width) / 100, (467 * Height) / 100);
            label_spravne.Font = new Font(label_spravne.Font.Name, (28 * Width) / 100, label_spravne.Font.Style);

            button1.Size = new Size((798 * Width) / 100, (105 * Height) / 100);
            button1.Location = new Point((156 * Width) / 100, (830 * Height) / 100);
            button1.Font = new Font(button1.Font.Name, (34 * Width) / 100, button1.Font.Style);

            button_Exit.Size = new Size((798 * Width) / 100, (102 * Height) / 100);
            button_Exit.Location = new Point((156 * Width) / 100, (966 * Height) / 100);
            button_Exit.Font = new Font(button_Exit.Font.Name, (28 * Width) / 100, button_Exit.Font.Style);

            label2.Size = new Size((477 * Width) / 100, (133 * Height) / 100);
            label2.Location = new Point((1432 * Width) / 100, (940 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (24 * Width) / 100, label2.Font.Style);

            tableLayoutPanel1.Size = new Size((346 * Width) / 100, (100 * Height) / 100);
            tableLayoutPanel1.Location = new Point((1513 * Width) / 100, (61 * Height) / 100);
            tableLayoutPanel1.Font = new Font(tableLayoutPanel1.Font.Name, (8 * Width) / 100, label2.Font.Style);

            label6.Size = new Size((269 * Width) / 100, (50 * Height) / 100);
            label6.Location = new Point((1508 * Width) / 100, (198 * Height) / 100);
            label6.Font = new Font(label6.Font.Name, (28 * Width) / 100, label6.Font.Style);

            button_testy.Size = new Size((50 * Width) / 100, (50 * Height) / 100);
            button_testy.Location = new Point((1809 * Width) / 100, (198 * Height) / 100);
            button_testy.Font = new Font(button_testy.Font.Name, (8 * Width) / 100, button_testy.Font.Style);

            this.Size = new Size((725 * Width) / 100, (449 * Height) / 100);
        }


        private void Victory_Load(object sender, EventArgs e)
        {
            NameObor.Visible = true;
            music.PlayLooping();
            
        }

        public void setBackNoMoney()
        {
            this.BackgroundImage = Properties.Resources.WinNoMoney;
        }

        public void setBackMoney() 
        {
            this.BackgroundImage = Properties.Resources.WinMoney;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        public void setOborName(string obor)
        {
            NameObor.Text = obor;
        }

        public void setFalse5050()
        {
            button_5050.BackgroundImage = Properties.Resources._5050Off;
        }
        public void setFalseAudiance()
        {
            button_HelpAudiance.BackgroundImage = Properties.Resources.audienceOff;
        }
        public void setFalseCall()
        {
            button_CallHelp.BackgroundImage = Properties.Resources.callOff;
        }

        public void resetObr()
        {
            button_testy.BackgroundImage = Properties.Resources._false;
            button_5050.BackgroundImage = Properties.Resources.a5050;
            button_HelpAudiance.BackgroundImage = Properties.Resources.audience;
            button_CallHelp.BackgroundImage = Properties.Resources.call;
        }

        private void transparent()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Exit, button1});
            for (int i = 0; i < 2; i++)
            {
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttons[i].BackColor = Color.Transparent;
            }
        }

        public void setOdpo(string odpovedi)
        {
            label_spravne.Text = "Správné odpovědi byly: " + odpovedi;
        }
        //zpátky do menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHandler.menu.Calibration();
            FormHandler.menu.Show();
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void noDalsi(string s)
        {
            label_obor.Text = "Tisíc korun z tebe asi Milionáře neudělá, alespoň jsi dobrým " + s +".";
            label_obor.Location = new Point(50, 353);
        }

        public void dalsiClick()
        {
            label_obor.Text = "Blahopřeji, úspěšně jsi prošel testem.";
            label_obor.Location = new Point(148, 375);
        }
        public void setVerze()
        {
            button_testy.BackgroundImage = Properties.Resources._true;
        }

        private void Victory_FormClosing(object sender, FormClosingEventArgs e)
        {
            music.Stop();
        }
    }
}
