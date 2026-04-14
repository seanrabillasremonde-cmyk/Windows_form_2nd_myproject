using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Form5 : Form
    {
        StudentData student;

        public Form5(StudentData data)
        {
            InitializeComponent();
            student = data;

            label1.Text = student.Name1 + " " + student.Name2 + " " + student.Name3;
            label2.Text = student.Birthdate;
            label3.Text = student.Age;
            label4.Text = student.Gender;
            label5.Text = student.Address;
            label6.Text = student.Course;
            label7.Text = student.Year;

            LoadImage();

        }


        private void LoadImage()
        {
            MessageBox.Show(student.ImagePath);
            MessageBox.Show(File.Exists(student.ImagePath).ToString());
            if (!string.IsNullOrEmpty(student.ImagePath) && File.Exists(student.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(student.ImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form4 f4 = new Form4();
            f4.TopLevel = false;   // <---- this is exit
            f4.FormBorderStyle = FormBorderStyle.None;
            f4.Dock = DockStyle.Fill;
            panel1.Controls.Add(f4);
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            Form3 f3 = new Form3(student); // <---- this is edit
            
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            panel1.Controls.Add(f3);
            f3.Show();
        }
    }
}