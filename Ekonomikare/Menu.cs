using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Menu : Form
    {
        private SoundPlayer music = new SoundPlayer(Properties.Resources.menumusic);
        //konstuktor
        public Menu()
        {
            InitializeComponent();
            showContie();
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

        //load formu
        private void Menu_Load(object sender, EventArgs e)
        {
            music.Play();
        }
        
        //začne novou hru
        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();
            this.Hide();
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            settings.read();
            this.Hide();
            music.Stop();
        }

        private void Contienue_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            this.Hide();
        }

        public void showContie()
        {
            if (!FormHandler.form1.getLose() && FormHandler.form1.getStep() > 0)
            {
                Contienue.Visible = true;
            }
            else
            {
                Contienue.Visible = false;
            }
        }
    }
}
