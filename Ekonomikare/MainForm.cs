﻿using Milionar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;


namespace Ekonomikare
{

    public partial class MainForm : Form
    {

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
        private Ask ask = new Ask();
        private List<Question> questions = new List<Question>();
        private bool button50;
        private bool loseBool = false;
        
        //konstruktor
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            readTXT();
            showQuestion();

        }

        //form load
        private void Main_Load_1(object sender, EventArgs e)
        {
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
            button_HelpAudiance.BackgroundImage = Properties.Resources.radaPubl;
            button_CallHelp.Enabled = true;
            button_CallHelp.BackgroundImage = Properties.Resources.pritel;
            ask.setAsk();
            for (int i = 0; i < 4; i++)
            {
                answers[i].Text = "";
                answers[i].Visible = false;
                progressBars[i].Value = 0;
            }
            button50 = false;
            loseBool = false;
            resetColor();
            showQuestion();
            step();
        }

        //zkontroluj
        private void checkAnswer()
        {
            
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
                    Lose lose = new Lose();
                    buttons[buttonek].BackColor = Color.Red;
                    buttons[currentQuestion.rightAnswer].BackColor = Color.Green;
                    loseBool = true;
                    FormHandler.form2.showContie();
                    lose.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Prosím vyber odpověd");
            }
        }

        public bool getLose()
        {
            return loseBool;
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
                buttons[i].BackColor = Color.FromArgb(25, 30, 60);
            }

        }

        //menu
        private void button_Menu_Click(object sender, EventArgs e)
        {
            FormHandler.form2.Show();
            FormHandler.form2.showContie();
            this.Hide();
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
            button50 = true;
            button_5050.Enabled = false;
            button_5050.BackgroundImage = Properties.Resources._5050Disabled;
        }

        //RadaPublika
        private void button_Audiance_Help_Click(object sender, EventArgs e)
        {
            ask.Show();
            ask.setAnswer();
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

        //metoda pro čtení txt
        public void readTXT()
        {
            int radky = 0;
            foreach (string line in System.IO.File.ReadLines("otazky.txt"))
            {
                radky++;
                List<string> hodnoty1 = new List<string>(line.Split(';'));
                if (hodnoty1.Count == 7)
                {
                    addQuestion(
                        int.Parse(hodnoty1[0]),
                        hodnoty1[1],
                        new string[4] { hodnoty1[2], hodnoty1[3], hodnoty1[4], hodnoty1[5] },
                        int.Parse(hodnoty1[6])
                        );
                } else
                {
                    Console.WriteLine("Chyba v otázkách na řádku - " + radky + " má jen " + hodnoty1.Count + " hodnot");
                }
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
        }

        //vypne tlačitko call friend
        public void callHelpDis()
        {
            button_CallHelp.Enabled = false;
            button_CallHelp.BackgroundImage = Properties.Resources.pritelx;
        }
        //kontrola
        private void button_Check_Click(object sender, EventArgs e)
        {
            button50 = false;
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