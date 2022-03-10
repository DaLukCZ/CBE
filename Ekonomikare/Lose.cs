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
    public partial class Lose : Form
    {
        //konstruktor
        public Lose()
        {
            InitializeComponent();
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

        //load formu
        private void Lose_Load(object sender, EventArgs e)
        {
            label3.Text = "Správná odpověď byla " + FormHandler.form1.getAnswer() + ".";
            label_pocet.Text = "" + FormHandler.form1.getStep() + " / 10";
        }

        //vypne aplikaci
        private void button_Answer1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //začne novou hru
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHandler.form1.restart();
        }

        //pošle do menu
        private void button_Menu_Click(object sender, EventArgs e)
        {
            FormHandler.form2.Show();
            FormHandler.form1.Hide();
            this.Hide();
        }
    }
}
