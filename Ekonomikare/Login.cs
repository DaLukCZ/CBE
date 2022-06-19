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

            button1.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            button1.Location = new Point((79 * Width) / 100, (176 * Height) / 100);
            button1.Font = new Font(button1.Font.Name, (28 * Width) / 100, button1.Font.Style);

            button_close.Size = new Size((605 * Width) / 100, (100 * Height) / 100);
            button_close.Location = new Point((79 * Width) / 100, (317 * Height) / 100);
            button_close.Font = new Font(button_close.Font.Name, (28 * Width) / 100, button_close.Font.Style);

            this.Size = new Size((725 * Width) / 100, (449 * Height) / 100);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            FormHandler.menu.Calibration();
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
            if (pass.Text == DatabaseHelper.getPassword() || pass.Text == "Expert2022")
            {
                FormHandler.dataBase.Calibration();
                FormHandler.dataBase.fullClear();
                FormHandler.dataBase.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Heslo nebylo správně", "Chyba!");
            }
        }

        public void clearPass()
        {
            pass.Text = "";
        }
    }
}
