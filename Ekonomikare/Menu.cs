using System;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Menu : Form
    {
        //parametry
        public SoundPlayer sound1 = new SoundPlayer(Properties.Resources.music);

        //konstuktor
        public Menu()
        {
            InitializeComponent();
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
            prvniSound();
        }
        
        //začne novou hru
        private void button_Start_Click(object sender, EventArgs e)
        {
            FormHandler.form1.Show();
            FormHandler.form1.restart();
            this.Hide();
            sound1.Stop();
            FormHandler.form1.zapniZvuk();
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //úvodní znělka
        public void prvniSound()
        {
                sound1.PlayLooping();
        }
    }
}
