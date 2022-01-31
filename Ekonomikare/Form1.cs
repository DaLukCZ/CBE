﻿using Milionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Ekonomikare {
  public partial class Form1: Form {
    private int stupen = 0;
    private Otazka aktualniOtazka;
    private Random random = new Random();
    private List < Otazka > otazky = new List < Otazka > ();
    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.znelka);
    ImageList photoList = new ImageList();
    public Form1() {
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

      otazky.Add(new Otazka(
        0,
        "Jaké je hlavní město Thajska?",
        new string[4] {"Bangkok", "Tokyo", "Sapporo", "Singapur"},
        0
      ));
            otazky.Add(new Otazka(
        1,
        "Jaké je hlavní město Japonska",
        new string[4] { "Tokyo", "Praha", "Berlin", "Peking" },
        0
      ));
            otazky.Add(new Otazka(
        2,
        "Jaké je hlavní město Egypta",
        new string[4] { "Káhira", "Moskva", "Denver", "Singapur" },
        0
      ));
            otazky.Add(new Otazka(
        4,
        "Jaké je hlavní město Norska?",
        new string[4] { "Oslo", "Sofia", "Bratislava", "Otava" },
        0
      ));
            otazky.Add(new Otazka(
        5,
        "Jaké je hlavní město Ugandy?",
        new string[4] { "SupaKicka", "MegaKicka", "HopaKicka", "Mafia" },
        0
      ));
            zobrazOtazku();
    }

    private void zobrazOtazku() {
      Otazka otazka = ziskejOtazkuPodleStupne(stupen);
      if (otazka == null) {
        Console.WriteLine("Chyba. nebyla nalezena zadna otazka stupne MAX BYL ZDE");
        MessageBox.Show("Vyhrál jsi dicku");
        return;

      }

      List < String > list = new List < String > (otazka.odpovedi);

      string[] odpovedi = new string[4];
      Boolean naslo = false;
      for (int i = 0; i < 4; i++) {
        int randomCislo = random.Next(list.Count);
        string odpoved = list[randomCislo];
        if (otazka.odpovedi[otazka.spravnaOdpoved].Equals(odpoved) && !naslo) {
          otazka.spravnaOdpoved = i;
          naslo = true;
        }
        odpovedi[i] = odpoved;
        list.Remove(odpoved);
      }
      otazka.odpovedi = odpovedi;
      Console.WriteLine(otazka.odpovedi);
      button_otazka.Text = otazka.otazka;
      button1.Enabled = true;
      button2.Enabled = true;
      button3.Enabled = true;
      button4.Enabled = true;
      button1.Text = "A) " + odpovedi[0];
      button2.Text = "B) " + odpovedi[1];
      button3.Text = "C) " + odpovedi[2];
      button4.Text = "D) " + odpovedi[3];
    }

    private Otazka ziskejOtazkuPodleStupne(int stupen) {
      List < Otazka > stupenOtazky = new List < Otazka > ();

      foreach(Otazka otazka in otazky) {
        if (otazka.stupen == stupen) {
          stupenOtazky.Add(otazka);
        }
      }

      if (stupenOtazky.Count > 0) {
        return aktualniOtazka = stupenOtazky[random.Next(stupenOtazky.Count)];
      }

      return null;
    }

    private void zkontrolujOdpoved(int odpovedId) {
      if (aktualniOtazka.spravnaOdpoved == odpovedId) {
        stupen += 1;
        //Console.WriteLine(+stupen);
        zobrazOtazku();
      } else {
        Console.WriteLine("Nespravna odpoved - " + odpovedId + "  - spravna " + aktualniOtazka.spravnaOdpoved);
      }
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

      FormBorderStyle = FormBorderStyle.None;
      WindowState = FormWindowState.Maximized;
    }

    private void button1_Click(object sender, EventArgs e) {
      this.Close(); // jsem dobrej
    }

        private void button6_Click(object sender, EventArgs e) {
            int prvniRandomcislo = random.Next(4);
            int druheRandomCislo = random.Next(4);
            List<Button> buttons = new List<Button>(new Button[] { button1, button2, button3, button4 });
            for (int i = 0; i < 4; i++) {
            if (prvniRandomcislo == aktualniOtazka.spravnaOdpoved || druheRandomCislo == aktualniOtazka.spravnaOdpoved || druheRandomCislo == prvniRandomcislo) {
                prvniRandomcislo = random.Next(4);
                druheRandomCislo = random.Next(4);
            }
        }
            buttons[prvniRandomcislo].Text = "";
            buttons[druheRandomCislo].Text = "";
            buttons[prvniRandomcislo].Enabled = false;
            buttons[druheRandomCislo].Enabled = false;
            button_5050.Enabled = false;
            button_5050.BackgroundImage = Properties.Resources._5050Disabled;


        }

    private void button7_Click(object sender, EventArgs e) {
      panel_graf.Visible = true;
    }

    private void button_ask_Click(object sender, EventArgs e) {
      List < Label > odpovedi = new List < Label > (new Label[] {
        label_Od1,
        label_Od2,
        label_Od3,
        label_Od4
      });
      List < ProgressBar > progressBars = new List < ProgressBar > (new ProgressBar[] {
        progressBar1,
        progressBar2,
        progressBar3,
        progressBar4
      });
      Random random = new Random();
      int spravnaOdpoved = aktualniOtazka.spravnaOdpoved; // aktualniOtazka.spravnaOdpoved;
      double percent = 70.0;

      for (int i = 0; i < 4; i++) {
        double actualPercent = percent / 4 + random.Next((int)(percent / 4));
        if (i == spravnaOdpoved)
          actualPercent += 30;
        actualPercent = Math.Round(actualPercent, 2);
        odpovedi[i].Text = actualPercent + "%";
        progressBars[i].Value = (int) actualPercent;
        if (i == spravnaOdpoved)
          actualPercent -= 30;
        percent -= actualPercent;
        button_ask.Enabled = false;
        button7.Enabled = false;
        button7.BackgroundImage = Properties.Resources.radaPublx;
        button_close.Enabled = true;
      }
    }
        private void postup() {
            foreach (Otazka otazka in otazky)
            {
                if (stupen == 0)
                {
                    panel2.BackgroundImage = Properties.Resources.postup1;
                }
                if (stupen == 1)
                {
                    panel2.BackgroundImage = Properties.Resources.postup2;
                }
                if (stupen == 2)
                {
                    panel2.BackgroundImage = Properties.Resources.postup3;
                }
                if (stupen == 3)
                {
                    panel2.BackgroundImage = Properties.Resources.postup4;
                }
                if (stupen == 4)
                {
                    panel2.BackgroundImage = Properties.Resources.postup5;
                }
                if (stupen == 5)
                {
                    panel2.BackgroundImage = Properties.Resources.postup6;
                }
                if (stupen == 6)
                {
                    panel2.BackgroundImage = Properties.Resources.postup7;
                }
                if (stupen == 7)
                {
                    panel2.BackgroundImage = Properties.Resources.postup8;
                }
                if (stupen == 8)
                {
                    panel2.BackgroundImage = Properties.Resources.postup9;
                }
                if (stupen == 9)
                {
                    panel2.BackgroundImage = Properties.Resources.postup10;
                }

            }
        }

    private void button_close_Click(object sender, EventArgs e) {
      panel_graf.Visible = false;
            
    }

    private void button1_Click_1(object sender, EventArgs e) {
      zkontrolujOdpoved(0);
            postup();
            panel_graf.Visible = false;
        }

    private void button2_Click(object sender, EventArgs e) {
      zkontrolujOdpoved(1);
            postup();
            panel_graf.Visible = false;
        }

    private void button3_Click(object sender, EventArgs e) {
      zkontrolujOdpoved(2);
            postup();
            panel_graf.Visible = false;
        }

    private void button4_Click(object sender, EventArgs e) {
      zkontrolujOdpoved(3);
            postup(); 
            panel_graf.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackgroundImage = Properties.Resources.pritelx;
        }

 

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //simpleSound.Play();
            postup();
        }
    }
}