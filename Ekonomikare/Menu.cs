using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Menu : Form
    {
        //parametry
        private bool song = true;
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.music);
        Settings settings = new Settings();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //simpleSound.Play();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();

            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            settings.Show();
        }
    }
}
