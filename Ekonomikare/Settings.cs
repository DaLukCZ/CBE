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
            FormHandler.menu.Show();
        }

        public void change()
        {
            if (!checkBox5050.Checked)
                FormHandler.main.setBool5050(false);
            else
                FormHandler.main.setBool5050(true);

            if (!checkBoxRada.Checked)
                FormHandler.main.setBoolRada(false);
            else
                FormHandler.main.setBoolRada(true);

            if (!checkBoxFriend.Checked)
                FormHandler.main.setBoolPritel(false);
            else
                FormHandler.main.setBoolPritel(true);

            if (!checkBoxUčitel.Checked)
                FormHandler.main.setDalsiBool(false);
            else
                FormHandler.main.setDalsiBool(true);

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
            List<Guna2CustomCheckBox> boxy = new List<Guna2CustomCheckBox>(new Guna2CustomCheckBox[] { checkBox5050, checkBoxRada, checkBoxFriend, checkBoxUčitel });
            foreach (string line in File.ReadLines("Testy/settings.txt"))
            {
                List<string> hodnoty = new List<string>(line.Split(';'));
                for (int i = 0; i < hodnoty.Count; i++)
                    addBool(bool.Parse(hodnoty[i]));
            }
            for (int i = 0; i < 4; i++)
            {
                boxy[i].Checked = booleany[i];
            }

        }

        public void write()
        {
            string radek = checkBox5050.Checked + ";" + checkBoxRada.Checked + ";" + checkBoxFriend.Checked + ";" + checkBoxUčitel.Checked;
            File.WriteAllText("Testy/settings.txt", radek);
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.Text != "Jiné")
            {
                FormHandler.main.setOtazky("Testy/" + dropDown.Text + "_testy.csv");
                FormHandler.main.clearQuestions();
                FormHandler.main.readTXT();
                FormHandler.menu.contie(false);
                FormHandler.victory.setText(dropDown.Text);
                FormHandler.menu.setText(dropDown.Text.ToUpper());
                FormHandler.main.setText(dropDown.Text.ToUpper());
            }
            else
            {
                buttonAplikovat.Visible = true;
                textBox.Visible = true;
                FormHandler.main.setOtazky("Testy/Jiné_testy.csv");
                FormHandler.main.clearQuestions();
                FormHandler.main.readTXT();
                FormHandler.menu.contie(false);
            }
            FormHandler.main.restart();
        }

        private void buttonAplikovat_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text.Length < 15)
            {
                FormHandler.victory.setText(textBox.Text);
                FormHandler.menu.setText(textBox.Text.ToUpper());
                FormHandler.main.setText(textBox.Text.ToUpper());
                buttonAplikovat.Visible = false;
                textBox.Visible = false;
            }
            else if (textBox.Text.Length >= 15 && textBox.Text.Length < 16)
            {
                MessageBox.Show("Překročil jste název o " + (textBox.Text.Length - 14) + " znak. Maximálně 14 znaků", "Příliš dlouhý název!");
            }
            else if (textBox.Text.Length >= 16 && textBox.Text.Length < 19)
            {
                MessageBox.Show("Překročil jste název o " + (textBox.Text.Length - 14) + " znaky. Maximálně 14 znaků", "Příliš dlouhý název!");
            }
            else if (textBox.Text.Length >= 19)
            {
                MessageBox.Show("Překročil jste název o " + (textBox.Text.Length - 14) + " znaků. Maximálně 14 znaků", "Příliš dlouhý název!");
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

        private void checkBoxUčitel_Click(object sender, EventArgs e)
        {
            write();
            change();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}