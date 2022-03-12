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
        //konsturktor
        public Ask()
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

        //tlačítko ask nastavuje na true
        public void setAsk()
        {
            button_Ask.Enabled = true;
        }

        //vrací labely
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
        //vrací progress bary
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

        //určuje/generuje kolik procent bude mít určitý progress bar
        private void button_Ask_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Label> answers = new List<Label>(new Label[] { label_Answer1, label_Answer2, label_Answer3, label_Answer4 });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4 });
            List<Button> buttons = new List<Button>(new Button[] { FormHandler.main.getButtons(1), FormHandler.main.getButtons(2), FormHandler.main.getButtons(3), FormHandler.main.getButtons(4) });
            int spravnaOdpoved = FormHandler.main.getCurrentAnswer();
            if (!FormHandler.main.get5050bool())
            {
                int randC1 = random.Next(36, 66);
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
                for (int i = 0; i < 4; i++)
                {
                    answers[i].Visible = true;
                }
            }
            else
            {
                int randC2 = random.Next(50, 75);
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
                for (int i = 0; i < 4; i++)
                {
                    if (buttons[i].Enabled)
                    {
                        answers[i].Visible = true;
                    }
                }

            }

            button_Ask.Enabled = false;
            FormHandler.main.setAudiance(false);
            FormHandler.main.setAudianceBack(Properties.Resources.audienceOff);
            button_close.Enabled = true;
        }

        //zavírá tento form
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //load formu
        private void Ask_Load(object sender, EventArgs e)
        {
            setAnswer();
        }

        //určuje text
        public void setAnswer()
        {
            label_A.Text = "A) " + FormHandler.main.getuCurrentAnswerOnButtonu(0);
            label_B.Text = "B) " + FormHandler.main.getuCurrentAnswerOnButtonu(1);
            label_C.Text = "C) " + FormHandler.main.getuCurrentAnswerOnButtonu(2);
            label_D.Text = "D) " + FormHandler.main.getuCurrentAnswerOnButtonu(3);
        }
    }
}
