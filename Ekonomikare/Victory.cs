using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekonomikare
{
    public partial class Victory : Form
    {

        public Victory()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Victory_Load(object sender, EventArgs e)
        {
            //song
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

        //zpátky do menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHandler.form1.Hide();
            FormHandler.form2.Show();
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setText(string s)
        {
            label2.Text = "Tisíc korun z tebe asi Milionáře neudělá, alespoň jsi dobrým " + s +".";
        }
    }
}
