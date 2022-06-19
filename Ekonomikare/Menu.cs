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
            Calibration();
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

            button_Start.Size = new Size((600 * Width) / 100, (100 * Height) / 100);
            button_Start.Location = new Point((75 * Width) / 100, (430 * Height) / 100);
            button_Start.Font = new Font(button_Start.Font.Name, (28 * Width) / 100, button_Start.Font.Style);

            Contienue.Size = new Size((600 * Width) / 100, (100 * Height) / 100);
            Contienue.Location = new Point((75 * Width) / 100, (430 * Height) / 100);
            Contienue.Font = new Font(Contienue.Font.Name, (28 * Width) / 100, Contienue.Font.Style);

            button_settings.Size = new Size((600 * Width) / 100, (100 * Height) / 100);
            button_settings.Location = new Point((75 * Width) / 100, (560 * Height) / 100);
            button_settings.Font = new Font(button_settings.Font.Name, (28 * Width) / 100, button_settings.Font.Style);

            button_testy.Size = new Size((600 * Width) / 100, (100 * Height) / 100);
            button_testy.Location = new Point((75 * Width) / 100, (690 * Height) / 100);
            button_testy.Font = new Font(button_testy.Font.Name, (28 * Width) / 100, button_testy.Font.Style);

            button_Exit.Size = new Size((600 * Width) / 100, (100 * Height) / 100);
            button_Exit.Location = new Point((75 * Width) / 100, (820 * Height) / 100);
            button_Exit.Font = new Font(button_Exit.Font.Name, (28 * Width) / 100, button_Exit.Font.Style);

            panel1.Size = new Size((600 * Width) / 100, (400 * Height) / 100);
            panel1.Location = new Point((75 * Width) / 100, (30 * Height) / 100);

            label1.Size = new Size((600 * Width) / 100, (71 * Height) / 100);
            label1.Location = new Point((3 * Width) / 100, (167 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (34 * Width) / 100, label1.Font.Style);

            this.Size = new Size((750 * Width) / 100, (950 * Height) / 100);
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
            FormHandler.main.Calibration();
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
            FormHandler.settings.Calibration();
            FormHandler.settings.Show();
            this.Hide();
        }

        private void Contienue_Click(object sender, EventArgs e)
        {
            FormHandler.main.Calibration();
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
                FormHandler.login.Calibration();
                FormHandler.login.clearPass();
                FormHandler.login.Show();
                music.Stop();
                this.Hide();
            }
            else
            {
                FormHandler.dataBase.Calibration();
                FormHandler.dataBase.fullClear();
                FormHandler.dataBase.Show();
                music.Stop();
                this.Hide();
            }
        }
    }
}
