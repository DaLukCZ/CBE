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
            transparent();
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

        private void transparent()
        {
            List<Button> buttons = new List<Button>(new Button[] { button_Exit, button1});
            for (int i = 0; i < 2; i++)
            {
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttons[i].BackColor = Color.Transparent;
            }
        }

        //zpátky do menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHandler.main.Hide();
            FormHandler.menu.playMusic();
            FormHandler.menu.Show();
        }

        //vypíná aplikaci
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setText(string s)
        {
            label_obor.Text = "Tisíc korun z tebe asi Milionáře neudělá, alespoň jsi dobrým " + s +".";
        }
    }
}
