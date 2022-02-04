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
    public partial class Ask : Form
    {
        public Ask()
        {
            InitializeComponent();
        }

        public void setAsk()
        {
            button_Ask.Enabled = true;
        }

        public Label getLabels(int label)
        {
            switch (label)
            {
                case 1:
                    return label_Answer1;
                case 2:
                    return label_Answer2;
                case 3:
                    return label_Answer3;
                case 4:
                    return label_Answer4;
                default:
                    return null;
            }
        }
        public ProgressBar getPG(int pg)
        {
            switch (pg)
            {
                case 1:
                    return progressBar1;
                case 2:
                    return progressBar2;
                case 3:
                    return progressBar3;
                case 4:
                    return progressBar4;
                default:
                    return null;
            }
        }


        private void button_Ask_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Label> answers = new List<Label>(new Label[] { label_Answer1, label_Answer2, label_Answer3, label_Answer4 });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4 });
            List<Button> buttons = new List<Button>(new Button[] { FormHandler.form1.getButtons(1), FormHandler.form1.getButtons(2), FormHandler.form1.getButtons(3), FormHandler.form1.getButtons(4) });
            int spravnaOdpoved = FormHandler.form1.getCurrentAnswer();
            if (FormHandler.form1.getButton5050())
            {
                int randC1 = random.Next(40, 70);
                int rest1 = (100 - randC1) - random.Next(10, 100 - randC1);
                int rest2 = 100 - rest1 - randC1 - random.Next(5, 100 - rest1 - randC1);
                int rest3 = 100 - rest2 - rest1 - randC1;
                List<int> rests = new List<int>(new int[] { rest1, rest2, rest3 });
                for (int i = 0; i < 4; i++)
                {
                    if (i == spravnaOdpoved)
                    {
                        answers[i].Text = randC1 + "%";
                        progressBars[i].Value = randC1;
                    }
                    if (i != spravnaOdpoved)
                    {
                        answers[i].Text = rests[0] + "%";
                        progressBars[i].Value = rests[0];
                        rests.RemoveAt(0);
                    }
                }

            }
            else
            {
                int randC2 = random.Next(55, 85);
                for (int i = 0; i < 4; i++)
                {
                    if (i == spravnaOdpoved)
                    {
                        answers[i].Text = randC2 + "%";
                        progressBars[i].Value = randC2;
                    }
                    if (i != spravnaOdpoved && buttons[i].Enabled)
                    {
                        answers[i].Text = (100 - randC2) + "%";
                        progressBars[i].Value = (100 - randC2);
                    }
                }

            }
            button_Ask.Enabled = false;
            FormHandler.form1.setAudiance(false);
            FormHandler.form1.setAudianceBack(Properties.Resources.helpAudianceX);
            button_close.Enabled = true;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
