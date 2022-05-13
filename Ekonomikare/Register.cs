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
    public partial class Register : Form
    {
        public Register()
        {

            InitializeComponent();
            transparent();
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
                Save.FlatStyle = FlatStyle.Flat;
                Save.FlatAppearance.BorderSize = 0;
                Save.FlatAppearance.MouseDownBackColor = Color.Transparent;
                Save.FlatAppearance.MouseOverBackColor = Color.Transparent;
                Save.BackColor = Color.Transparent;

                Cancel.FlatStyle = FlatStyle.Flat;
                Cancel.FlatAppearance.BorderSize = 0;
                Cancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
                Cancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
                Cancel.BackColor = Color.Transparent;
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            DatabaseHelper.setPassWord(pass.Text);
        }

        private void button_Cencel_Click(object sender, EventArgs e)
        {
            DatabaseHelper.resetPassWord();
        }
        public void clearPass()
        {
            pass.Text = "";
        }
    }
}
