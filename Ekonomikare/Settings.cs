using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Settings : Form
    {
        public int ClickCount = 1;
        Menu menu = new Menu();
        public Settings()
        {
            InitializeComponent();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickCount++;
            Console.WriteLine(ClickCount);
            setImage();
        }

        private void setImage() {
            switch (ClickCount)
            {
                case 0:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
                case 1:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
                case 2:
                    button1.BackgroundImage = Properties.Resources.soundoff;
                    break;
                case 3:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
                case 4:
                    button1.BackgroundImage = Properties.Resources.soundoff;
                    break;
                case 5:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
                case 6:
                    button1.BackgroundImage = Properties.Resources.soundoff;
                    break;
                case 7:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
                case 8:
                    button1.BackgroundImage = Properties.Resources.soundoff;
                    break;
                case 9:
                    button1.BackgroundImage = Properties.Resources.sound;
                    break;
            }
        }

        public int getClickCount() { 
            return ClickCount;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
