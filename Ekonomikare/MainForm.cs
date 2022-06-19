using Chcete_byt_EXPERTEM;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;


namespace Chcete_byt_EXPERTEM
{

    public partial class MainForm : Form
    {

        private static List<QuestionHelper> _questions = new List<QuestionHelper>();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        //parametry
        private int Currentstep = 0;
        private int buttonek = 5;
        private Question currentQuestion;
        private Random random = new Random();
        private List<Question> questions = new List<Question>();
        private bool button50;
        private bool loseBool = false;
        private int spravnéOdpovědi = 0;
        string otazky = "Testy/Jiné_testy.csv";
        private SoundPlayer music = new SoundPlayer(Properties.Resources.musicMain);
        private List<char> odpovediChar = new List<char>();

        //konstruktor
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            Calibration();
            readDatabase();
            showQuestion();
            transparent();
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

            button_exit.Size = new Size((219 * Width) / 100, (82 * Height) / 100);
            button_exit.Location = new Point((82 * Width) / 100, (36 * Height) / 100);

            button_menu.Size = new Size((219 * Width) / 100, (82 * Height) / 100);
            button_menu.Location = new Point((1619 * Width) / 100, (36 * Height) / 100);

            button_otazka.Size = new Size((1150 * Width) / 100, (175 * Height) / 100);
            button_otazka.Location = new Point((390 * Width) / 100, (400 * Height) / 100);

            label_otazka.Size = new Size((961 * Width) / 100, (141 * Height) / 100);
            label_otazka.Location = new Point((484 * Width) / 100, (417 * Height) / 100);
            label_otazka.Font = new Font(label_otazka.Font.Name, (24 * Width) / 100, label_otazka.Font.Style);

            button_Answer1.Size = new Size((575 * Width) / 100, (175 * Height) / 100);
            button_Answer1.Location = new Point((390 * Width) / 100, (600 * Height) / 100);
            button_Answer1.Font = new Font(button_Answer1.Font.Name, (20 * Width) / 100, button_Answer1.Font.Style);

            button_Answer2.Size = new Size((575 * Width) / 100, (175 * Height) / 100);
            button_Answer2.Location = new Point((965 * Width) / 100, (600 * Height) / 100);
            button_Answer2.Font = new Font(button_Answer2.Font.Name, (20 * Width) / 100, button_Answer2.Font.Style);

            button_Answer3.Size = new Size((575 * Width) / 100, (175 * Height) / 100);
            button_Answer3.Location = new Point((390 * Width) / 100, (770 * Height) / 100);
            button_Answer3.Font = new Font(button_Answer3.Font.Name, (20 * Width) / 100, button_Answer3.Font.Style);

            button_Answer4.Size = new Size((575 * Width) / 100, (175 * Height) / 100);
            button_Answer4.Location = new Point((965 * Width) / 100, (770 * Height) / 100);
            button_Answer4.Font = new Font(button_Answer4.Font.Name, (20 * Width) / 100, button_Answer4.Font.Style);

            button_Zkontroluj.Size = new Size((565 * Width) / 100, (93 * Height) / 100);
            button_Zkontroluj.Location = new Point((683 * Width) / 100, (951 * Height) / 100);
            button_Zkontroluj.Font = new Font(button_Zkontroluj.Font.Name, (20 * Width) / 100, button_Zkontroluj.Font.Style);

            button_další.Size = new Size((369 * Width) / 100, (52 * Height) / 100);
            button_další.Location = new Point((1538 * Width) / 100, (1015 * Height) / 100);
            button_další.Font = new Font(button_další.Font.Name, (20 * Width) / 100, button_další.Font.Style);

            pictureBox2.Size = new Size((467 * Width) / 100, (685 * Height) / 100);
            pictureBox2.Location = new Point((1435 * Width) / 100, (328 * Height) / 100);

            panel2.Size = new Size((349 * Width) / 100, (545 * Height) / 100);
            panel2.Location = new Point((1556 * Width) / 100, (294 * Height) / 100);

            tableLayoutPanel1.Size = new Size((346 * Width) / 100, (100 * Height) / 100);
            tableLayoutPanel1.Location = new Point((1556 * Width) / 100, (188 * Height) / 100);

            label2.Size = new Size((565 * Width) / 100, (50 * Height) / 100);
            label2.Location = new Point((683 * Width) / 100, (213 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (34 * Width) / 100, label2.Font.Style);

            this.Size = new Size((1920 * Width) / 100, (1080 * Height) / 100);
        }

        private void transparent()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4, button_Zkontroluj, button_otazka, button_další, reset });
            for (int i = 0; i < 8 ; i++)
            {
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttons[i].BackColor = Color.Transparent;
            }
        }

        //form load
        private void Main_Load_1(object sender, EventArgs e)
        {
            music.PlayLooping();
            step();
        }

        public bool get5050bool()
        {
            return button50;
        }

        //addOtazka
        private void addQuestion(int step, string question, string[] answers, int rightAnswer)
        {
            questions.Add(new Question(
            step - 1,
            question,
            answers,
            rightAnswer - 1
        ));
        }

        public void clearQuestions()
        {
            questions.Clear();
        }

        //zobrazOtazku
        public void showQuestion()
        {
            buttonek = 5;
            resetColor();
            Question question = getQuestionByStep(Currentstep);
            if (question == null)
            {

                return;

            }
            List<string> list = new List<string>(question.answers);
            string[] answers = new string[4];
            bool naslo = false;
            for (int i = 0; i < 4; i++)
            {
                int randomCislo = random.Next(list.Count);
                string odpoved = list[randomCislo];
                if (question.answers[question.rightAnswer].Equals(odpoved) && !naslo)
                {
                    question.rightAnswer = i;
                    naslo = true;
                }
                answers[i] = odpoved;
                list.Remove(odpoved);
            }
            question.answers = answers;
            label_otazka.Text = question.question;
            button_Answer1.Enabled = true;
            button_Answer2.Enabled = true;
            button_Answer3.Enabled = true;
            button_Answer4.Enabled = true;
            button_Answer1.Text = "A) " + answers[0];
            button_Answer2.Text = "B) " + answers[1];
            button_Answer3.Text = "C) " + answers[2];
            button_Answer4.Text = "D) " + answers[3];
        }

        private void saveAnswer()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            odpovediChar.Add(buttons[currentQuestion.rightAnswer].Text[0]);
        }

        public void resetOdpovediChar()
        {
            odpovediChar.Clear();
        }

        public string getSpravnePismena()
        {
            return string.Join(", ", odpovediChar);
        }


        //getQuestionByStep
        private Question getQuestionByStep(int step)
        {
            List<Question> stepQuestion = new List<Question>();

            foreach (Question question in questions)
            {
                if (question.step == step)
                {
                    stepQuestion.Add(question);
                }
            }

            if (stepQuestion.Count > 0)
            {
                return currentQuestion = stepQuestion[random.Next(stepQuestion.Count)];
            }

            return null;
        }

        //restart
        public void restart()
        {
            List<Label> answers = new List<Label>(new Label[] { FormHandler.ask.getLabels(1), FormHandler.ask.getLabels(2), FormHandler.ask.getLabels(3), FormHandler.ask.getLabels(4) });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { FormHandler.ask.getPG(1), FormHandler.ask.getPG(2), FormHandler.ask.getPG(3), FormHandler.ask.getPG(4) });
            label2.Visible = true;
            Currentstep = 0;
            spravnéOdpovědi = 0;
            buttonek = 5;
            panel2.Visible = true;
            pictureBox2.Visible = false;
            button_5050.Enabled = true;
            button_5050.BackgroundImage = Properties.Resources.a5050;
            button_HelpAudiance.Enabled = true;
            button_HelpAudiance.BackgroundImage = Properties.Resources.audience;
            button_CallHelp.Enabled = true;
            button_CallHelp.BackgroundImage = Properties.Resources.call;
            FormHandler.victory.setBackMoney();
            FormHandler.victory.resetObr();
            FormHandler.victory.noDalsi(label2.Text);
            FormHandler.ask.setAsk();
            for (int i = 0; i < 4; i++)
            {
                answers[i].Text = "";
                answers[i].Visible = false;
                progressBars[i].Value = 0;
            }
            button50 = false;
            loseBool = false;
            resetOdpovediChar();
            resetColor();
            showQuestion();
            step();
        }

        public int getSpravne()
        {
            return spravnéOdpovědi;
        }

        //zkontroluj
        private void checkAnswer()
        {

            if (!loseBool)
            {
                List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
                if (buttonek != 5) {
                    if (currentQuestion.rightAnswer == buttonek)
                    {
                        if (Currentstep != 9)
                        {
                            Currentstep += 1;
                            spravnéOdpovědi += 1;
                            showQuestion();
                            step();
                        }
                        else
                        {
                            spravnéOdpovědi += 1;
                            music.Stop();
                            this.Hide();
                            FormHandler.menu.contie(false);
                            FormHandler.victory.Calibration();
                            FormHandler.victory.Show();
                        }
                    }
                    else
                    {
                        music.Stop();
                        panel2.Visible = false;
                        pictureBox2.Visible = true;
                        buttons[buttonek].BackgroundImage = Properties.Resources.buttonBorderRed;
                        buttons[currentQuestion.rightAnswer].BackgroundImage = Properties.Resources.buttonBorderGreen;
                        FormHandler.menu.contie(false);
                        loseBool = true;
                        FormHandler.lose.Calibration();
                        FormHandler.lose.setText();
                        FormHandler.lose.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Prosím vyber odpověd");
                }
            }
        }

        //mark
        private void mark(int answerID)
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            if (!loseBool)
                buttons[answerID].BackgroundImage = Properties.Resources.buttonBorderGold;
        }

        //resetColor
        private void resetColor()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            for (int i = 0; i < 4; i++)
            {
                buttons[i].BackgroundImage = Properties.Resources.buttonBorderPink;
            }

        }

        //menu
        private void button_Menu_Click(object sender, EventArgs e)
        {
            if (!loseBool)
            {
                music.Stop();
                FormHandler.menu.Calibration();
                FormHandler.menu.Show();
                FormHandler.menu.contie(true);
                this.Hide();
            }
        }

        public void setBool5050(bool zmena) {
            button_5050.Visible = zmena;
        }

        public void setBoolRada(bool zmena)
        {
            button_HelpAudiance.Visible = zmena;
        }
        public void setBoolPritel(bool zmena)
        {
            button_CallHelp.Visible = zmena;
        }

        //50/50
        private void button_5050_Click(object sender, EventArgs e)
        {
            resetColor();
            if (!loseBool)
            {
                List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
                List<int> numbers = new List<int>();

                for (int i = 0; i < 4; i++)
                {
                    if (currentQuestion.rightAnswer != i)
                    {
                        numbers.Add(i);
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    int number = numbers[random.Next(numbers.Count)];
                    buttons[number].Text = "";
                    buttons[number].Enabled = false;
                    numbers.Remove(number);
                }
                FormHandler.victory.setFalse5050();
                button50 = true;
                button_5050.Enabled = false;
                button_5050.BackgroundImage = Properties.Resources._5050Off;
            }
        }


        //RadaPublika
        private void button_Audiance_Help_Click(object sender, EventArgs e)
        {
            if (!loseBool)
            {
                FormHandler.victory.setFalseAudiance();
                FormHandler.ask.Calibration();
                FormHandler.ask.setAnswer();
                FormHandler.ask.Show();
            }
        }

        //obrazky
        private void step()
        {
            switch (Currentstep)
            {
                case 0:
                    panel2.BackgroundImage = Properties.Resources.postup0;
                    break;
                case 1:
                    panel2.BackgroundImage = Properties.Resources.postup1;
                    break;
                case 2:
                    panel2.BackgroundImage = Properties.Resources.postup2;
                    break;
                case 3:
                    panel2.BackgroundImage = Properties.Resources.postup3;
                    break;
                case 4:
                    panel2.BackgroundImage = Properties.Resources.postup4;
                    break;
                case 5:
                    panel2.BackgroundImage = Properties.Resources.postup5;
                    break;
                case 6:
                    panel2.BackgroundImage = Properties.Resources.postup6;
                    break;
                case 7:
                    panel2.BackgroundImage = Properties.Resources.postup7;
                    break;
                case 8:
                    panel2.BackgroundImage = Properties.Resources.postup8;
                    break;
                case 9:
                    panel2.BackgroundImage = Properties.Resources.postup9;
                    break;
            }
        }

        //metoda pro získání odpovědi
        public string getAnswer()
        {
            return currentQuestion.answers[currentQuestion.rightAnswer];
        }

        //getuje aktuální odpověd na určitém buttonu pro používání v jiných formech
        public string getuCurrentAnswerOnButtonu(int button)
        {
            return currentQuestion.answers[button];
        }

        //getuje aktualní otázku pro používání v jiných formech
        public string getQuestion()
        {
            return currentQuestion.question;
        }

        //getuje aktuální pro používání v jiných formech
        public int getStep()
        {
            return Currentstep;
        }

        //getuje aktuální odpověd pro používání v jiných formech
        public int getCurrentAnswer()
        {
            return currentQuestion.rightAnswer;
        }

        //getuje button5050 pro používání v jiných formech
        public bool getButton5050()
        {
            return button_5050.Enabled;
        }

        //getuje buttony 1-4 pro používání v jiných formech
        public Button getButtons(int button)
        {
            switch (button)
            {
                case 1:
                    return button_Answer1;
                case 2:
                    return button_Answer2;
                case 3:
                    return button_Answer3;
                case 4:
                    return button_Answer4;
                default:
                    return null;
            }
        }

        //nastavuje pomoc publika
        public void setAudiance(bool boolean)
        {
            button_HelpAudiance.Enabled = boolean;
        }

        //nastavuje obrázek publika
        public void setAudianceBack(Bitmap bitmap)
        {
            button_HelpAudiance.BackgroundImage = bitmap;
        }

        public void setOtazky(string ot)
        {
            otazky = ot;
        }

        //metoda pro čtení txt
        public void readTXT()
        {
            int radky = 0;
            foreach (string line in System.IO.File.ReadLines(otazky))
            {
                radky++;
                if (radky != 1) {
                    List<string> hodnoty1 = new List<string>(line.Split(';'));
                    if (hodnoty1.Count == 7)
                    {
                        addQuestion(
                                int.Parse(hodnoty1[0]),
                                hodnoty1[1],
                                new string[4] { hodnoty1[2], hodnoty1[3], hodnoty1[4], hodnoty1[5] },
                                int.Parse(hodnoty1[6])
                            );
                    }
                    else
                    {
                        MessageBox.Show("Chyba v otázkách na řádku " + radky + " má jen " + hodnoty1.Count + " hodnot", "Chyba v otázkách!");
                    }
                }
            }
        }
        public void readDatabase(string obor = "Expertem")
        {

            _questions = DatabaseHelper.GetQuestions(obor);

            foreach(QuestionHelper helper in _questions)
            {
                addQuestion(
                        helper.obtiznost,
                        helper.otazka,
                        new string[4] { helper.odpoved_1, helper.odpoved_2, helper.odpoved_3, helper.odpoved_4 },
                        helper.spravna_odpoved
                           );
            }
        }

        //odpoved1
        private void button_Answer1_Click(object sender, EventArgs e)
        {
            click(0);
        }

        public bool getButtonsBool(int button)
        {
            switch (button)
            {
                case 1:
                    return button_Answer1.Enabled;
                case 2:
                    return button_Answer1.Enabled;
                case 3:
                    return button_Answer1.Enabled;
                case 4:
                    return button_Answer1.Enabled;
                default:
                    return false;
            }
        }

        //odpoved2
        private void button_Answer2_Click(object sender, EventArgs e)
        {
            click(1);
        }

        //odpoved3
        private void button_Answer3_Click(object sender, EventArgs e)
        {
            click(2);
        }

        //odpoved4
        private void button_Answer4_Click(object sender, EventArgs e)
        {
            click(3);
        }

        //click
        private void click(int id)
        {
            if (!loseBool)
            {
                buttonek = id;
                resetColor();
                mark(id);
            }
            FormHandler.ask.Hide();
        }

        //pritelTelefon
        private void button_Call_Help_Click(object sender, EventArgs e)
        {
            if (!loseBool)
            {
                FormHandler.victory.setFalseCall();
                CallHelp callHelp = new CallHelp();
                callHelpDis();
                callHelp.Calibration();
                callHelp.Show();
            }
        }

        //vypne tlačitko call friend
        public void callHelpDis()
        {
            button_CallHelp.Enabled = false;
            button_CallHelp.BackgroundImage = Properties.Resources.callOff;
        }

        //kontrola
        private void button_Check_Click(object sender, EventArgs e)
        {
            button50 = false;
            FormHandler.ask.Hide();
            checkAnswer();
        }

        //exit
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void setText(string s)
        {
            label2.Text = s;
        }

        public void setDalsiBool(bool vis)
        {
            button_další.Visible = vis;
        }

        private void button_dalsi_Click(object sender, EventArgs e)
        {
            if (!loseBool)
            {
                FormHandler.victory.setVerze();
                FormHandler.victory.dalsiClick();
                FormHandler.victory.setBackNoMoney();
                if (Currentstep != 9)
                {
                    Currentstep += 1;
                    saveAnswer();
                    showQuestion();
                    step();
                }
                else
                {
                    saveAnswer();
                    FormHandler.victory.setOdpo(getSpravnePismena());
                    music.Stop();
                    this.Hide();
                    FormHandler.victory.Calibration();
                    FormHandler.menu.contie(false);
                    FormHandler.victory.Show();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            music.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calibration();
        }
    }
}