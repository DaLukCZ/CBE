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

            label4.Size = new Size((400 * Width) / 100, (100 * Height) / 100);
            label4.Location = new Point((175 * Width) / 100, (25 * Height) / 100);
            label4.Font = new Font(label4.Font.Name, (60 * Width) / 100, label4.Font.Style);

            label5.Size = new Size((400 * Width) / 100, (50 * Height) / 100);
            label5.Location = new Point((175 * Width) / 100, (150 * Height) / 100);
            label5.Font = new Font(label5.Font.Name, (28 * Width) / 100, label5.Font.Style);

            dropDown.Font = new Font(label4.Font.Name, (24 * Width) / 100, label4.Font.Style);
            dropDown.Size = new Size((400 * Width) / 100, (47 * Height) / 100);
            dropDown.Location = new Point((175 * Width) / 100, (200 * Height) / 100);

            label1.Size = new Size((325 * Width) / 100, (50 * Height) / 100);
            label1.Location = new Point((175 * Width) / 100, (350 * Height) / 100);
            label1.Font = new Font(label1.Font.Name, (28 * Width) / 100, label1.Font.Style);

            label2.Size = new Size((325 * Width) / 100, (50 * Height) / 100);
            label2.Location = new Point((175 * Width) / 100, (475 * Height) / 100);
            label2.Font = new Font(label2.Font.Name, (28 * Width) / 100, label2.Font.Style);

            label3.Size = new Size((325 * Width) / 100, (50 * Height) / 100);
            label3.Location = new Point((175 * Width) / 100, (600 * Height) / 100);
            label3.Font = new Font(label3.Font.Name, (28 * Width) / 100, label3.Font.Style);

            label6.Size = new Size((325 * Width) / 100, (50 * Height) / 100);
            label6.Location = new Point((175 * Width) / 100, (725 * Height) / 100);
            label6.Font = new Font(label6.Font.Name, (28 * Width) / 100, label6.Font.Style);

            checkBox5050.Size = new Size((50 * Width) / 100, (50 * Height) / 100);
            checkBox5050.Location = new Point((525 * Width) / 100, (350 * Height) / 100);

            checkBoxRada.Size = new Size((50 * Width) / 100, (50 * Height) / 100);
            checkBoxRada.Location = new Point((525 * Width) / 100, (475 * Height) / 100);

            checkBoxFriend.Size = new Size((50 * Width) / 100, (50 * Height) / 100);
            checkBoxFriend.Location = new Point((525 * Width) / 100, (600 * Height) / 100);

            checkBoxUčitel.Size = new Size((50 * Width) / 100, (50 * Height) / 100);
            checkBoxUčitel.Location = new Point((525 * Width) / 100, (725 * Height) / 100);

            button1.Size = new Size((400 * Width) / 100, (50 * Height) / 100);
            button1.Location = new Point((175 * Width) / 100, (838 * Height) / 100);
            button1.Font = new Font(button1.Font.Name, (28 * Width) / 100, button1.Font.Style);


            this.Size = new Size((750 * Width) / 100, (950 * Height) / 100);
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
            FormHandler.menu.Calibration();
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