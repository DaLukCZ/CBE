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
    public partial class Rada : Form
    {
        public Rada()
        {
            InitializeComponent();
        }

        private void Rada_Load(object sender, EventArgs e)
        {

        }

        public void ahoj() {
            List<Label> odpovedi = new List<Label>(new Label[] { label_Od1, label_Od2, label_Od3, label_Od4 });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4 });
            int spravnaOdpoved = FormHandler.form1.aktualniOtazka.spravnaOdpoved;
            double percent = 70.0;
            for (int i = 0; i < 4; i++)
            {
                double actualPercent = percent / 4 + random.Next((int)(percent / 4));
                if (i == spravnaOdpoved)
                    actualPercent += 30;
                actualPercent = Math.Round(actualPercent, 2);
                odpovedi[i].Text = actualPercent + "%";
                progressBars[i].Value = (int)actualPercent;
                if (i == spravnaOdpoved)
                    actualPercent -= 30;
                percent -= actualPercent;
                FormHandler.form1.button_ask.Enabled = false;
                button_RadaPublika.Enabled = false;
                button_RadaPublika.BackgroundImage = Properties.Resources.radaPublx;
                button_close.Enabled = true;
            }
        }
    }
}
