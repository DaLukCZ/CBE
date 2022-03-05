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
        private List<bool> buttony = new List<bool>();

        public Settings()
        {

            InitializeComponent();
            write();
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

        private void checkBox5050_CheckedChanged(object sender, EventArgs e)
        {
            change();
            write();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void checkBox_Rada_CheckedChanged(object sender, EventArgs e)
        {
            change();
            write();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        public void addBool(bool B)
        {
            buttony.Add(B);
        }

        private void read() {
            foreach (string line in File.ReadLines("settings.txt"))
            {
                List<string> hodnoty1 = new List<string>(line.Split(';'));
                for (int i = 0; i < hodnoty1.Count; i++)
                    addBool(bool.Parse(hodnoty1[i]));
            }
        }

        private void write(){
            string radek = checkBox5050.Checked + ";" + checkBoxRada.Checked + ";" + checkBoxFriend.Checked + ";";
            File.WriteAllText("rady.txt" , radek);
        }

        private void checkBoxFriend_CheckedChanged(object sender, EventArgs e)
        {
            change();
            write();
        }
    }
}
