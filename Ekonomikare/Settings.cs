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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            showTXT();
        }

        private void showTXT()
        {
            string text = System.IO.File.ReadAllText("test.txt");
            label1.Text = text;
        }
    }
}
