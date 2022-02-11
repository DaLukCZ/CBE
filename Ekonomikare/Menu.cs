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
            button_Settings.Visible = false;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();
            //FormHandler.form1.zapniZvuk();  
            this.Hide();
            sound1.Stop();
            FormHandler.form1.setSoundy2(soundy);
            //Console.WriteLine(getSoundy());
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            //settings.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            zmenPolaritu();
            if (soundy)
            {
                sound1.PlayLooping();
                button1.BackgroundImage = Properties.Resources.soundoff;
            }
            else {
                button1.BackgroundImage = Properties.Resources.sound;
                sound1.Stop();
            }
        }

        public void prvniSound()
        {
            if (soundy)
            {
                sound1.PlayLooping();
            }
            else {
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
