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
    public partial class Lose : Form
    {
        //konstruktor
        public Lose()
        {
            InitializeComponent();
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

            label1.Font = new Font(label1.Font.Name, (36 * Width) / 100, label1.Font.Style);
            label1.Location = new Point((126 * Width) / 100, (60 * Height) / 100);
            label1.Size = new Size((496 * Width) / 100, (59 * Height) / 100);

            label3.Size = new Size((625 * Width) / 100, (86 * Height) / 100);
            label3.Location = new Point((59 * Width) / 100, (141 * Height) / 100);
            label3.Font = new Font(label3.Font.Name, (22 * Width) / 100, label3.Font.Style);

            label_pocet.Font = new Font(label3.Font.Name, (22 * Width) / 100, label3.Font.Style);
            label_pocet.Location = new Point((341 * Width) / 100, (241 * Height) / 100);

            button_newGame.Size = new Size((177 * Width) / 100, (104 * Height) / 100);
            button_newGame.Location = new Point((65 * Width) / 100, (333 * Height) / 100);
            button_newGame.Font = new Font(button_newGame.Font.Name, (18 * Width) / 100, button_newGame.Font.Style);

            button_Menu.Size = new Size((177 * Width) / 100, (104 * Height) / 100);
            button_Menu.Location = new Point((282 * Width) / 100, (333 * Height) / 100);
            button_Menu.Font = new Font(button_Menu.Font.Name, (18 * Width) / 100, button_Menu.Font.Style);

            button_exit.Size = new Size((177 * Width) / 100, (104 * Height) / 100);
            button_exit.Location = new Point((500 * Width) / 100, (333 * Height) / 100);
            button_exit.Font = new Font(button_exit.Font.Name, (18 * Width) / 100, button_exit.Font.Style);

            this.Size = new Size((741 * Width) / 100, (488 * Height) / 100);
            this.Location = new Point((590 * Width) / 100, (10 * Height) / 100);
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
            setText();
        }

        public void setText()
        {
            label3.Text = "Správná odpověď byla " + FormHandler.main.getAnswer() + ".";
            label_pocet.Text = FormHandler.main.getSpravne() + " / 10";
        }

        //vypne aplikaci
        private void button_Answer1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //začne novou hru
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHandler.main.Calibration();
            FormHandler.main.restart();
        }

        //pošle do menu
        private void button_Menu_Click(object sender, EventArgs e)
        {
            FormHandler.menu.Calibration();
            FormHandler.menu.Show();
            FormHandler.main.Hide();
            this.Hide();
        }
    }
}
