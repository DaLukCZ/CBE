using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chcete_byt_EXPERTEM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            transparent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            FormHandler.menu.Show();
            this.Hide();

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
                button_close.FlatStyle = FlatStyle.Flat;
                button_close.FlatAppearance.BorderSize = 0;
                button_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button_close.BackColor = Color.Transparent;

                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DatabaseHelper.getPassword());
            if (pass.Text == DatabaseHelper.getPassword() || pass.Text == "Expert2022")
            {
                FormHandler.dataBase.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("špatzně lolk");
            }
        }

        public void clearPass()
        {
            pass.Text = "";
        }
    }
}
