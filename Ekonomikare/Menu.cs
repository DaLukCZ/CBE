using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Menu : Form
    {
        //parametry
        private bool kontrola = false;
        SoundPlayer multipleSound = new SoundPlayer(Properties.Resources.hudbavpozadi);
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.music);
        Settings settings = new Settings();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Music();
            //simpleSound.Play();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();
            this.Hide();
            bool kontrola = true;
            //simpleSound.Stop();
            //multipleSound.Play();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            settings.Show();
        }

        public void Music() {
            switch (settings.getClickCount()) 
            {
                case 0:
                    break;
                case 1:
                    simpleSound.Play();
                    if(kontrola == true) { 
                        simpleSound.Stop();
                        multipleSound.Play();
                    }
                    break;
                case 2:
                    simpleSound.Stop();
                    if (kontrola == true)
                    {
                        multipleSound.Stop();
                    }
                    break;
                case 3:
                    simpleSound.Play();
                    if (kontrola == true)
                    {
                        simpleSound.Stop();
                        multipleSound.Play();
                    }
                    break;
            }
        }

    }
}
