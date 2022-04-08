using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Victory : Form
    {

        private SoundPlayer music = new SoundPlayer(Properties.Resources.musicVictory);
        public Victory()
        {
            InitializeComponent();
            transparent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
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
