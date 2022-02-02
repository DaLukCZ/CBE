using Milionar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace Ekonomikare
{

    public partial class form1 : Form
    {
        //parametry
        private int stupen = 0;
        private int tlacidlo = 5;
        private Otazka aktualniOtazka;
        private Random random = new Random();
        private List<Otazka> otazky = new List<Otazka>();
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.znelka);
        ImageList photoList = new ImageList();
        public form1()
        {
            photoList.Images.Add(Properties.Resources.postup0);
            photoList.Images.Add(Properties.Resources.postup1);
            photoList.Images.Add(Properties.Resources.postup2);
            photoList.Images.Add(Properties.Resources.postup3);
            photoList.Images.Add(Properties.Resources.postup4);
            photoList.Images.Add(Properties.Resources.postup5);
            photoList.Images.Add(Properties.Resources.postup6);
            photoList.Images.Add(Properties.Resources.postup7);
            photoList.Images.Add(Properties.Resources.postup8);
            photoList.Images.Add(Properties.Resources.postup9);
            photoList.Images.Add(Properties.Resources.postup10);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            addOtazka(
                0,
                "Jaké je hlavní město Thajska?",
                new string[4] { "Bangkok", "Tokyo", "Sapporo", "Singapur" },
                0
            );
            addOtazka(
                1,
                "Jaké je hlavní město Japonska",
                new string[4] { "Tokyo", "Praha", "Berlin", "Peking" },
                0
            );
            addOtazka(
                2,
                "Jaké je hlavní město Egypta",
                new string[4] { "Káhira", "Moskva", "Denver", "Singapur" },
                0
            );
            addOtazka(
                3,
                "Jaké je hlavní město Austrálie",
                new string[4] { "Canberra", "Sydney", "Perth", "Melbourne" },
                0
            );
            addOtazka(
                4,
                "Jaké je hlavní město Norska?",
                new string[4] { "Oslo", "Sofia", "Bratislava", "Otava" },
                0
            );
            addOtazka(
                5,
                "Jaké je hlavní město Ugandy?",
                new string[4] { "SupaKicka", "MegaKicka", "HopaKicka", "Mafia" },
                0
            );
            addOtazka(
                6,
                "Jaké je hlavní město Česka?",
                new string[4] { "Praha", "Mamka", "HopaKicka", "Mafia" },
                0
                );
            zobrazOtazku();
        }

        //form1
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //simpleSound.Play();
            postup();
        }

        //addOtazka
        private void addOtazka(int stupen, string otazka, string[] odpovedi, int spravnaOdpoved)
        {
            otazky.Add(new Otazka(
                stupen,
                otazka,
                odpovedi,
                spravnaOdpoved
            ));
        }

        //zobrazOtazku
        private void zobrazOtazku()
        {
            tlacidlo = 5;
            button_Odpoved1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button_Odpoved2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button_Odpoved3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button_Odpoved4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            Otazka otazka = ziskejOtazkuPodleStupne(stupen);
            if (otazka == null)
            {

                return;

            }

            List<String> list = new List<String>(otazka.odpovedi);

            string[] odpovedi = new string[4];
            Boolean naslo = false;
            for (int i = 0; i < 4; i++)
            {
                int randomCislo = random.Next(list.Count);
                string odpoved = list[randomCislo];
                if (otazka.odpovedi[otazka.spravnaOdpoved].Equals(odpoved) && !naslo)
                {
                    otazka.spravnaOdpoved = i;
                    naslo = true;
                }
                odpovedi[i] = odpoved;
                list.Remove(odpoved);
            }
            otazka.odpovedi = odpovedi;
            button_otazka.Text = otazka.otazka;
            button_Odpoved1.Enabled = true;
            button_Odpoved2.Enabled = true;
            button_Odpoved3.Enabled = true;
            button_Odpoved4.Enabled = true;
            button_Odpoved1.Text = "A) " + odpovedi[0];
            button_Odpoved2.Text = "B) " + odpovedi[1];
            button_Odpoved3.Text = "C) " + odpovedi[2];
            button_Odpoved4.Text = "D) " + odpovedi[3];
        }

        //ziskejOtazkuPodleStupne
        private Otazka ziskejOtazkuPodleStupne(int stupen)
        {
            List<Otazka> stupenOtazky = new List<Otazka>();

            foreach (Otazka otazka in otazky)
            {
                if (otazka.stupen == stupen)
                {
                    stupenOtazky.Add(otazka);
                }
            }

            if (stupenOtazky.Count > 0)
            {
                return aktualniOtazka = stupenOtazky[random.Next(stupenOtazky.Count)];
            }

            return null;
        }

        //zkontroluj
        private void zkontrolujOdpoved()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Odpoved1, button_Odpoved2, button_Odpoved3, button_Odpoved4 });
            try
            {
                if (aktualniOtazka.spravnaOdpoved == tlacidlo)
                {
                    if (stupen != 9)
                    {
                        stupen += 1;
                        zobrazOtazku();
                        postup();
                    }
                    else
                    {
                        this.Hide();
                        Vitez v = new Vitez();
                        v.Show();
                    }
                }
                else
                {
                    buttons[tlacidlo].BackColor = Color.Red;
                    buttons[aktualniOtazka.spravnaOdpoved].BackColor = Color.Green;
                    if (stupen >= 0 && stupen <= 2)
                    {
                        MessageBox.Show("Odcházíš stejně jako jsi přišel");
                    }
                    else if (stupen >= 3 && stupen <= 6)//záchraný bod 4
                    {
                        MessageBox.Show("Blahopřejeme odcházíš o 10Kč bohatší");
                        
                    }
                    else if (stupen >= 7 && stupen <= 8)//záchraný bod 8
                    {
                        MessageBox.Show("Blahopřejeme odcházíš 200Kč bohatší");
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Prosím vyber odpověd");
            }
        }

        //mark
        private void mark(int odpovedId)
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Odpoved1, button_Odpoved2, button_Odpoved3, button_Odpoved4 });
            buttons[odpovedId].BackColor = Color.DodgerBlue;
        }

        //resetColor
        private void resetColor()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Odpoved1, button_Odpoved2, button_Odpoved3, button_Odpoved4 });
            for (int i = 0; i < 4; i++)
            {
                buttons[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }

        }

        //MenuButton
        private void button_Menu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        //50/50
        private void button_5050_Click(object sender, EventArgs e)
        {
            resetColor();
            List<Button> buttons = new List<Button>(new Button[] { button_Odpoved1, button_Odpoved2, button_Odpoved3, button_Odpoved4 });
            List<int> cisla = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                if (aktualniOtazka.spravnaOdpoved != i)
                {
                    cisla.Add(i);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                int cislo = cisla[random.Next(cisla.Count)];
                buttons[cislo].Text = "";
                buttons[cislo].Enabled = false;
                cisla.Remove(cislo);
            }
            button_5050.Enabled = false;
            button_5050.BackgroundImage = Properties.Resources._5050Disabled;
        }

        //RadaPublika
        private void button_RadaPublika_Click(object sender, EventArgs e)
        {
            panel_graf.Visible = true;
        }

        //AskButton
        private void button_Ask_Click(object sender, EventArgs e)
        {
            List<Label> odpovedi = new List<Label>(new Label[] { label_Od1, label_Od2, label_Od3, label_Od4 });
            List<ProgressBar> progressBars = new List<ProgressBar>(new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4 });
            int spravnaOdpoved = aktualniOtazka.spravnaOdpoved;
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
                button_ask.Enabled = false;
                button7.Enabled = false;
                button7.BackgroundImage = Properties.Resources.radaPublx;
                button_close.Enabled = true;
            }
        }

        //obrazky
        private void postup()
        {
            switch (stupen)
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

        //grafClose
        private void button_GrafClose_Click(object sender, EventArgs e)
        {
            panel_graf.Visible = false;
        }

        //odpoved1
        private void button_Odpoved1_Click(object sender, EventArgs e)
        {
            click(0);
        }

        //odpoved2
        private void button_Odpoved2_Click(object sender, EventArgs e)
        {
            click(1);
        }

        //odpoved3
        private void button_Odpoved3_Click(object sender, EventArgs e)
        {
            click(2);
        }

        //odpoved4
        private void button_Odpoved4_Click(object sender, EventArgs e)
        {
            click(3);
        }

        //click
        private void click(int id)
        {
            tlacidlo = id;
            resetColor();
            mark(id);
            panel_graf.Visible = false;
        }

        //pritelTelefon
        private void button_PritelTelefon_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackgroundImage = Properties.Resources.pritelx;
        }

        //kontrola
        private void button_Zkontroluj_Click(object sender, EventArgs e)
        {
            zkontrolujOdpoved();
        }
    }
}