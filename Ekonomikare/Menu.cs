using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Menu : Form
    {
        //parametry
        private bool soundy = true;
        public SoundPlayer sound1 = new SoundPlayer(Properties.Resources.music);

        //Settings settings = new Settings();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            prvniSound();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();
            this.Hide();
            sound1.Stop();
            FormHandler.form1.zapniZvuk();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            //settings.Show();
        }

        public void prvniSound()
        {
            if (soundy)
            {
                sound1.PlayLooping();
            }
            else
            {
                sound1.Stop();
            }
        }

        public bool getSoundy()
        {
            return soundy;
        }

        public void zmenPolaritu()
        {
            if (soundy)
            {
                soundy = false;
            }
            else
            {
                soundy = true;
            }
        }
    }
}
