﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= 24;i++)
            {
                progressBar1.PerformStep();
            }
            Form2 frm = new Form2();
            frm.Show();
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                button2.BackColor = Color.Red;

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
