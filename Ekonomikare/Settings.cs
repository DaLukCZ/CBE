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

namespace Chcete_byt_EXPERTEM
{
    public partial class Settings : Form
    {
        private List<bool> booleany = new List<bool>();
        public string obor;
        List<ScopesHelper> scopes = new List<ScopesHelper>();


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
            fillComboBox();
        }

        public void addBool(bool B)
        {
            booleany.Add(B);
        }

        public void read()
        {
            List<Guna2CustomCheckBox> boxy = new List<Guna2CustomCheckBox>(new Guna2CustomCheckBox[] { checkBox5050, checkBoxRada, checkBoxFriend, checkBoxUčitel });
            foreach (string line in File.ReadLines("settings.txt"))
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
            File.WriteAllText("settings.txt", radek);
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.Text != "Expertem")
            {
                FormHandler.main.clearQuestions();
                FormHandler.main.readDatabase(dropDown.Text);
                FormHandler.main.showQuestion();
                FormHandler.menu.contie(false);
                FormHandler.victory.noDalsi(dropDown.Text);
                FormHandler.menu.setText(dropDown.Text.ToUpper());
                FormHandler.main.setText(dropDown.Text.ToUpper());
            }
            else
            {
                FormHandler.main.clearQuestions();
                FormHandler.main.readDatabase(dropDown.Text);    
                FormHandler.main.showQuestion();
                FormHandler.menu.contie(false);
            }
            FormHandler.main.restart();
        }

        public void fillComboBox()
        {
            try
            {
                scopes = DatabaseHelper.getScopes();

                dropDown.Items.Clear();
                foreach (ScopesHelper scHelper in scopes)
                {
                    dropDown.Items.Add(scHelper.obor_nazev);
                }
                dropDown.Items.Add("Expertem");
                dropDown.Update();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}