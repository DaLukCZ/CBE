using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Guna.UI2.WinForms;

namespace Ekonomikare
{
    public partial class Settings : Form
    {
        private List<bool> booleany = new List<bool>();
        public string obor;

        public Settings()
        {
            InitializeComponent();
            read();
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHandler.form2.Show();
        }

        public void change()
        {
            if (!checkBox5050.Checked)
                FormHandler.form1.setBool5050(false);
            else
                FormHandler.form1.setBool5050(true);

            if (!checkBoxRada.Checked)
                FormHandler.form1.setBoolRada(false);
            else
                FormHandler.form1.setBoolRada(true);

            if (!checkBoxFriend.Checked)
                FormHandler.form1.setBoolPritel(false);
            else
                FormHandler.form1.setBoolPritel(true);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            read();
        }

        public void addBool(bool B)
        {
            booleany.Add(B);
        }

        public void read()
        {
            List<Guna2CustomCheckBox> boxy = new List<Guna2CustomCheckBox>(new Guna2CustomCheckBox[] { checkBox5050, checkBoxRada, checkBoxFriend });
            foreach (string line in File.ReadLines("settings.txt"))
            {
                List<string> hodnoty = new List<string>(line.Split(';'));
                for (int i = 0; i < hodnoty.Count; i++)
                    addBool(bool.Parse(hodnoty[i]));
            }
            for (int i = 0; i < 3; i++)
            {
                boxy[i].Checked = booleany[i];
            }

        }

        public void write()
        {
            string radek = checkBox5050.Checked + ";" + checkBoxRada.Checked + ";" + checkBoxFriend.Checked;
            File.WriteAllText("settings.txt", radek);
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Už chci spát, kurvfga " + dropDown.Text);
            if (dropDown.Text != "Jiné")
            {
                FormHandler.form1.setOtazky(dropDown.Text + "_otázky.txt");
                FormHandler.form1.clearQuestions();
                FormHandler.form1.readTXT();
                FormHandler.form2.contie(false);
                FormHandler.form2.setText(dropDown.Text.ToUpper());
                FormHandler.form1.setText(dropDown.Text.ToUpper());
            }
            else
            {
                buttonAplikovat.Visible = true;
                textBox.Visible = true;
                FormHandler.form1.setOtazky("Jiné_otázky.txt");
                FormHandler.form1.clearQuestions();
                FormHandler.form1.readTXT();
                FormHandler.form2.contie(false);
            }
            FormHandler.form1.restart();
        }

        private void buttonAplikovat_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text.Length < 13)
            {
                FormHandler.form2.setText(textBox.Text.ToUpper());
                FormHandler.form1.setText(textBox.Text.ToUpper());
                buttonAplikovat.Visible = false;
                textBox.Visible = false;
            }
            else if (textBox.Text.Length >= 13)
            {
                MessageBox.Show("Název je přiliš dlouhý. Maximálně 12 znaků", "Příliš dlouhý název!");
            }
            else
            {
                MessageBox.Show("Prosím zadejte název", "Nebyl zadán název");
            }
        }

        private void checkBox5050_CheckedChanged(object sender, EventArgs e)
        {
            write();
            change();
        }

        private void checkBoxRada_CheckedChanged(object sender, EventArgs e)
        {
            write();
            change();
        }

        private void checkBoxFriend_CheckedChanged(object sender, EventArgs e)
        {
            write();
            change();
        }
    }
}