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

namespace Ekonomikare
{
    public partial class Settings : Form
    {
        private List<bool> booleany = new List<bool>();

        public Settings()
        {

            InitializeComponent();
            update();
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

        private void checkBox5050_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
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

            if(!checkBoxRada.Checked)
                FormHandler.form1.setBoolRada(false);
            else
                FormHandler.form1.setBoolRada(true);

            if(!checkBoxFriend.Checked)
                FormHandler.form1.setBoolPritel(false);
            else
                FormHandler.form1.setBoolPritel(true);

        }

        public void update()
        {
            read();
            write();
        }
        private void checkBox_Rada_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            update();
        }

        public void addBool(bool B)
        {
            booleany.Add(B);
        }

        private void read() {
            List<Guna.UI2.WinForms.Guna2CustomCheckBox> boxy = new List<Guna.UI2.WinForms.Guna2CustomCheckBox>(new Guna.UI2.WinForms.Guna2CustomCheckBox[] { checkBox5050, checkBoxRada, checkBoxFriend });
            foreach (string line in File.ReadLines("settings.txt"))
            {
                List<string> hodnoty1 = new List<string>(line.Split(';'));
                for (int i = 0; i < hodnoty1.Count; i++)
                    addBool(bool.Parse(hodnoty1[i]));
            }
            for (int i = 0; i < 3; i++) {
                boxy[i].Checked = booleany[i];
            }

        }

        private void write(){
            string radek = checkBox5050.Checked + ";" + checkBoxRada.Checked + ";" + checkBoxFriend.Checked;
            File.WriteAllText("settings.txt", radek);
        }

        private void checkBoxFriend_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
