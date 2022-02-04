using Milionar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace Ekonomikare
{

    public partial class MainForm : Form
    {
        //parametry
        private int Currentstep = 0;
        private int buttonek = 5;
        private Question currentQuestion;
        private Random random = new Random();
        private Ask ask = new Ask();
        private List<Question> questions = new List<Question>();
        ImageList photoList = new ImageList();
        public MainForm()
        {
            photoList.Images.Add(Properties.Resources.step0);
            photoList.Images.Add(Properties.Resources.step1);
            photoList.Images.Add(Properties.Resources.step2);
            photoList.Images.Add(Properties.Resources.step3);
            photoList.Images.Add(Properties.Resources.step4);
            photoList.Images.Add(Properties.Resources.step5);
            photoList.Images.Add(Properties.Resources.step6);
            photoList.Images.Add(Properties.Resources.step7);
            photoList.Images.Add(Properties.Resources.step8);
            photoList.Images.Add(Properties.Resources.step9);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            addQuestion(
                0,
                "Jaké je hlavní město Thajska?",
                new string[4] { "Bangkok", "Tokyo", "Sapporo", "Singapur" },
                0
            );
            addQuestion(
                1,
                "Jaké je hlavní město Japonska",
                new string[4] { "Tokyo", "Praha", "Berlin", "Peking" },
                0
            );
            addQuestion(
                2,
                "Jaké je hlavní město Egypta",
                new string[4] { "Káhira", "Moskva", "Denver", "Singapur" },
                0
            );
            addQuestion(
                3,
                "Jaké je hlavní město Austrálie",
                new string[4] { "Canberra", "Sydney", "Perth", "Melbourne" },
                0
            );
            addQuestion(
                4,
                "Jaké je hlavní město Norska?",
                new string[4] { "Oslo", "Sofia", "Bratislava", "Otava" },
                0
            );
            addQuestion(
                5,
                "Jaké je hlavní město Sloveska?",
                new string[4] { "Bratislava", "Praha", "Vídeň", "Brno" },
                0
            );

            addQuestion(
                6,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            addQuestion(
                6,
                "Jaké je hlavní město Německa?",
                new string[4] { "Berlin", "Ottava", "Hop", "Mafia" },
                0
                );
            addQuestion(
                7,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            addQuestion(
                8,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            addQuestion(
                9,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            addQuestion(
                10,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            showQuestion();
        }

        //form1
        private void Main_Load_1(object sender, EventArgs e)
        {
            step();
        }

        //addOtazka
        private void addQuestion(int step, string question, string[] answers, int rightAnswer)
        {
            questions.Add(new Question(
            step,
            question,
            answers,
            rightAnswer
        ));
        }

        //zobrazOtazku
        private void showQuestion()
        {
            buttonek = 5;
            button_Answer1.BackColor = System.Drawing.Color.FromArgb(25, 30, 60);
            button_Answer2.BackColor = System.Drawing.Color.FromArgb(25, 30, 60);
            button_Answer3.BackColor = System.Drawing.Color.FromArgb(25, 30, 60);
            button_Answer4.BackColor = System.Drawing.Color.FromArgb(25, 30, 60);
            Question question = getQuestionByStep(Currentstep);
            if (question == null)
            {

                return;

            }
            List<String> list = new List<String>(question.answers);
            string[] answers = new string[4];
            Boolean naslo = false;
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
            List<Label> answers = new List<Label>(new Label[] { ask.getLabels(1), ask.getLabels(2), ask.getLabels(3), ask.getLabels(4) });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { ask.getPG(1), ask.getPG(2), ask.getPG(3), ask.getPG(4) });
            Currentstep = 0;
            buttonek = 5;
            button_5050.Enabled = true;
            button_5050.BackgroundImage = Properties.Resources._5050;
            button_HelpAudiance.Enabled = true;
            button_HelpAudiance.BackgroundImage = Properties.Resources.helpAudiance;
            button_CallHelp.Enabled = true;
            button_CallHelp.BackgroundImage = Properties.Resources.callFriend;
            ask.setAsk();
            for (int i = 0; i < 4; i++)
            {
                answers[i].Text = "";
                progressBars[i].Value = 0;
            }

            resetColor();
            showQuestion();
            step();
        }

        //zkontroluj
        private void checkAnswer()
        {
            Lose lose = new Lose();
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            try
            {
                if (currentQuestion.rightAnswer == buttonek)
                {
                    if (Currentstep != 9)
                    {
                        Currentstep += 1;
                        showQuestion();
                        step();
                    }
                    else
                    {
                        this.Hide();
                        Victory victory = new Victory();
                        victory.Show();
                    }
                }
                else
                {
                    buttons[buttonek].BackColor = Color.Red;
                    buttons[currentQuestion.rightAnswer].BackColor = Color.Green;
                    lose.Show();
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Prosím vyber odpověd");
            }
        }

        //mark
        private void mark(int answerID)
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            buttons[answerID].BackColor = Color.DodgerBlue;
        }

        //resetColor
        private void resetColor()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Answer1, button_Answer2, button_Answer3, button_Answer4 });
            for (int i = 0; i < 4; i++)
            {
                buttons[i].BackColor = System.Drawing.Color.FromArgb(25, 30, 60);
            }

        }

        //menu
        private void button_Menu_Click(object sender, EventArgs e)
        {
            FormHandler.form2.Show();
            this.Hide();
        }

        //50/50
        private void button_5050_Click(object sender, EventArgs e)
        {
            resetColor();
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
            button_5050.Enabled = false;
            button_5050.BackgroundImage = Properties.Resources._5050X;
        }

        //RadaPublika
        private void button_Audiance_Help_Click(object sender, EventArgs e)
        {
            ask.Show();
        }
        //obrazky
        private void step()
        {
            switch (Currentstep)
            {
                case 0:
                    panel2.BackgroundImage = Properties.Resources.step0;
                    break;
                case 1:
                    panel2.BackgroundImage = Properties.Resources.step1;
                    break;
                case 2:
                    panel2.BackgroundImage = Properties.Resources.step2;
                    break;
                case 3:
                    panel2.BackgroundImage = Properties.Resources.step3;
                    break;
                case 4:
                    panel2.BackgroundImage = Properties.Resources.step4;
                    break;
                case 5:
                    panel2.BackgroundImage = Properties.Resources.step5;
                    break;
                case 6:
                    panel2.BackgroundImage = Properties.Resources.step6;
                    break;
                case 7:
                    panel2.BackgroundImage = Properties.Resources.step7;
                    break;
                case 8:
                    panel2.BackgroundImage = Properties.Resources.step8;
                    break;
                case 9:
                    panel2.BackgroundImage = Properties.Resources.step9;
                    break;
            }
        }

        //metoda pro získání odpovědi
        public string getAnswer()
        {
            return currentQuestion.answers[currentQuestion.rightAnswer];
        }

        public string getQuestion()
        {
            return currentQuestion.question;
        }

        public int getStep()
        {
            return Currentstep;
        }

        public int getCurrentAnswer()
        {
            return currentQuestion.rightAnswer;
        }

        public bool getButton5050()
        {
            return button_5050.Enabled;
        }

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

        public void setAudiance(bool boolean)
        {
            button_HelpAudiance.Enabled = boolean;
        }

        public void setAudianceBack(Bitmap bitmap)
        {
            button_HelpAudiance.BackgroundImage = bitmap;
        }

        //odpoved1
        private void button_Answer1_Click(object sender, EventArgs e)
        {
            click(0);
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
            buttonek = id;
            resetColor();
            mark(id);
            ask.Hide();
        }

        //pritelTelefon
        private void button_Call_Help_Click(object sender, EventArgs e)
        {
            CallHelp help = new CallHelp();
            help.Show();
            button_CallHelp.Enabled = false;
            button_CallHelp.BackgroundImage = Properties.Resources.CallFriendX;
        }

        //kontrola
        private void button_Check_Click(object sender, EventArgs e)
        {
            ask.Hide();
            checkAnswer();
        }

        //exit
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}