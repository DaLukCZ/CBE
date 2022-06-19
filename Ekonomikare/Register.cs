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

            pass.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            pass.Location = new Point((79 * Width) / 100, (35 * Height) / 100);
            pass.Font = new Font(pass.Font.Name, (28 * Width) / 100, pass.Font.Style);

            Save.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            Save.Location = new Point((79 * Width) / 100, (176 * Height) / 100);
            Save.Font = new Font(Save.Font.Name, (28 * Width) / 100, Save.Font.Style);

            Cancel.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            Cancel.Location = new Point((79 * Width) / 100, (317 * Height) / 100);
            Cancel.Font = new Font(Cancel.Font.Name, (28 * Width) / 100, Cancel.Font.Style);

            this.Size = new Size((725 * Width) / 100, (449 * Height) / 100);
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
            if(pass.Text.Length >= 5 && pass.Text.Length <= 16)
            {
                DatabaseHelper.setPassword(pass.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Heslo musí být 5-16 znaků dlouhé", "Heslo má špatný formát");
            }
        }

        private void button_Cencel_Click(object sender, EventArgs e)
        {
            DatabaseHelper.resetPassword();
            this.Hide();
        }
        public void clearPass()
        {
            pass.Text = "";
        }
    }
}
