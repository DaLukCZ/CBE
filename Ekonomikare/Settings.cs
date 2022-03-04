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
using Newtonsoft.Json;

namespace Ekonomikare
{
    public partial class Settings : Form
    {
        private List<bool> buttony = new List<bool>();

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

        private void checkBox5050_CheckedChanged(object sender, EventArgs e)
        {
            change5050();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHandler.form2.Show();
            this.Hide();
        }

        public void change5050()
        {
            if (!checkBox5050.Checked)
            {
                FormHandler.form1.setBool(false);
                //File.ReadA
            }
            else
                FormHandler.form1.setBool(true);
        }

        public void setCheckBox5050()
        {
            checkBox5050.Checked = FormHandler.form1.getButton5050();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }
    
        private bool toBoolean(string S)
        {
            if (S == "true")
                return true;
            else
                return false;
        }

        public void addBool(bool B)
        {
            buttony.Add(B);
        }

        private void read() {
            foreach (string line in File.ReadLines("rady.json"))
            {
                List<string> hodnoty1 = new List<string>(line.Split(';'));
                for (int i = 0; i < hodnoty1.Count; i++)
                    addBool(toBoolean(hodnoty1[i]));
            }
            Console.WriteLine("sgnjsdkg    " + buttony[2]);
        }
    }
}
