﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            Vitez v = new Vitez();
            //form1.Show();
            this.Hide();
            v.Show();
        }
    }
}
