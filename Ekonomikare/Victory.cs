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
        }

        private void Victory_Load(object sender, EventArgs e)
        {
            //song
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHandler.form1.Hide();
            FormHandler.form2.Show();
        }
    }
}
