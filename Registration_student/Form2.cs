using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;

            this.AutoScaleMode = AutoScaleMode.None;
            panel1.Controls.Add(f1);
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form3 f3 = new Form3();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;

            this.AutoScaleMode = AutoScaleMode.None;
            panel1.Controls.Add(f3);
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form4 f3 = new Form4();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;

          
            f3.Dock = DockStyle.Fill;
            panel1.Controls.Add(f3);
            f3.Show();
        }
    }
}
