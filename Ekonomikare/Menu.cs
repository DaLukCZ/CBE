using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    public partial class Menu : Form
    {
        private SoundPlayer music = new SoundPlayer(Properties.Resources.musicMenu);
        //konstuktor
        public Menu()
        {
            InitializeComponent();
            transparent();
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

        private void transparent()
        {
            List<Button> buttons = new List<Button>(new Button[] { Contienue, button_Start, button_settings, button_Exit });
            for (int i = 0; i < 4; i++) {
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttons[i].BackColor = Color.Transparent;
            }
        }

        //load formu
        private void Menu_Load(object sender, EventArgs e)
        {
            music.PlayLooping();
        }
        
        //začne novou hru
        private void button_Start_Click(object sender, EventArgs e)
        {
            contie(true);
            music.Stop();
            FormHandler.main.Show();
            FormHandler.main.restart();
            this.Hide();
        }

        public void contie(bool pravda)
        {
            Contienue.Visible = pravda;
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHandler.settings.Show();
            this.Hide();
        }

        private void Contienue_Click(object sender, EventArgs e)
        {
            FormHandler.main.Show();
            music.Stop();
            this.Hide();
        }
        public void setText(string s) {
            label1.Text = s;
        }
        public string getText()
        {
            return label1.Text;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            music.Stop();
        }

        private void button_testy_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.getPassword() != "DisabledPassword")
            {
                FormHandler.login.clearPass();
                FormHandler.login.Show();
                music.Stop();
                this.Hide();
            }
            else
            {
                FormHandler.dataBase.Show();
                music.Stop();
                this.Hide();
            }
        }
    }
}
