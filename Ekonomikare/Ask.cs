using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chcete_byt_EXPERTEM
{
    public partial class Ask : Form
    {
        //konsturktor
        public Ask()
        {
            InitializeComponent();
            transparent();
            Calibration();
        }

        public int getSizeW()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            decimal screenWidthPercent = (decimal)screenWidth / 1920 * 100;
            return (int)screenWidthPercent;
        }

        public int getSizeH()
        {
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            decimal screenHeightPercent = (decimal)screenHeight / 1080 * 100;
            return (int)screenHeightPercent;
        }

        public void Calibration()
        {
            int Width = getSizeW();
            int Height = getSizeH();

            label1.Location = new Point((27 * Width) / 100, (65 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (16 * Width) / 100, label1.Font.Style);

            label2.Location = new Point((27 * Width) / 100, (132 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (16 * Width) / 100, label2.Font.Style);

            label3.Location = new Point((27 * Width) / 100, (199 * Height) / 100);
            label3.Font = new Font(label3.Font.Name, (16 * Width) / 100, label3.Font.Style);

            label4.Location = new Point((27 * Width) / 100, (264 * Height) / 100);
            label4.Font = new Font(label4.Font.Name, (16 * Width) / 100, label4.Font.Style);

            label_A.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            label_A.Location = new Point((65 * Width) / 100, (53 * Height) / 100);
            label_A.Font = new Font(label4.Font.Name, (14 * Width) / 100, label4.Font.Style);

            label_B.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            label_B.Location = new Point((65 * Width) / 100, (121 * Height) / 100);
            label_B.Font = new Font(label_B.Font.Name, (14 * Width) / 100, label_B.Font.Style);

            label_C.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            label_C.Location = new Point((65 * Width) / 100, (188 * Height) / 100);
            label_C.Font = new Font(label_C.Font.Name, (14 * Width) / 100, label_C.Font.Style);

            label_D.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            label_D.Location = new Point((65 * Width) / 100, (253 * Height) / 100);
            label_D.Font = new Font(label_D.Font.Name, (14 * Width) / 100, label_D.Font.Style);

            progressBar1.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            progressBar1.Location = new Point((395 * Width) / 100, (53 * Height) / 100);

            progressBar2.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            progressBar2.Location = new Point((395 * Width) / 100, (121 * Height) / 100);

            progressBar3.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            progressBar3.Location = new Point((395 * Width) / 100, (188 * Height) / 100);

            progressBar4.Size = new Size((275 * Width) / 100, (50 * Height) / 100);
            progressBar4.Location = new Point((395 * Width) / 100, (253 * Height) / 100);

            label_Answer1.Size = new Size((50 * Width) / 100, (25 * Height) / 100);
            label_Answer1.Location = new Point((508 * Width) / 100, (66 * Height) / 100);
            label_Answer1.Font = new Font(label_Answer1.Font.Name, (14 * Width) / 100, label_Answer1.Font.Style);

            label_Answer2.Size = new Size((50 * Width) / 100, (25 * Height) / 100);
            label_Answer2.Location = new Point((508 * Width) / 100, (133 * Height) / 100);
            label_Answer2.Font = new Font(label_Answer2.Font.Name, (14 * Width) / 100, label_Answer2.Font.Style);

            label_Answer3.Size = new Size((50 * Width) / 100, (25 * Height) / 100);
            label_Answer3.Location = new Point((508 * Width) / 100, (200 * Height) / 100);
            label_Answer3.Font = new Font(label_Answer3.Font.Name, (14 * Width) / 100, label_Answer3.Font.Style);

            label_Answer4.Size = new Size((50 * Width) / 100, (25 * Height) / 100);
            label_Answer4.Location = new Point((508 * Width) / 100, (265 * Height) / 100);
            label_Answer4.Font = new Font(label_Answer4.Font.Name, (14 * Width) / 100, label_Answer4.Font.Style);

            button_close.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            button_close.Location = new Point((65 * Width) / 100, (338 * Height) / 100);
            button_close.Font = new Font(button_close.Font.Name, (28 * Width) / 100, button_close.Font.Style);

            button_Ask.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            button_Ask.Location = new Point((65 * Width) / 100, (338 * Height) / 100);
            button_Ask.Font = new Font(button_Ask.Font.Name, (28 * Width) / 100, button_Ask.Font.Style);

            this.Location = new Point((590 * Width) / 100, (10 * Height) / 100);
            this.Size = new Size((741 * Width) / 100, (488 * Height) / 100);
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

        private void transparent()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Ask, button_close });
            for (int i = 0; i < 2; i++)
            {
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttons[i].BackColor = Color.Transparent;
            }
        }

        //tlačítko ask nastavuje na true
        public void setAsk()
        {
            button_close.Visible = false;
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
            button_close.Visible = true;
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
            label_A.Text = FormHandler.main.getuCurrentAnswerOnButtonu(0);
            label_B.Text = FormHandler.main.getuCurrentAnswerOnButtonu(1);
            label_C.Text = FormHandler.main.getuCurrentAnswerOnButtonu(2);
            label_D.Text = FormHandler.main.getuCurrentAnswerOnButtonu(3);
        }
    }
}
