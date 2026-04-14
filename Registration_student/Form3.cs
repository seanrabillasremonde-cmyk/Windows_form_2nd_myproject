using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Form3 : Form
    {
       StudentData student;
List<StudentData> users;
string path = "students.json";

   public Form3(StudentData data)
   {
        InitializeComponent();
      student = data;
   }
        private void Form3_Load(object sender, EventArgs e)
        {
            // comboBox setup
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            comboBox2.Items.Add("1st Year");
            comboBox2.Items.Add("2nd Year");
            comboBox2.Items.Add("3rd Year");
            comboBox2.Items.Add("4th Year");

            // Load student data 
            textBox1.Text = student.Name1;
            textBox2.Text = student.Name2;
            textBox3.Text = student.Name3;

            dateTimePicker1.Text = student.Birthdate;

            numericUpDown1.Value = int.Parse(student.Age);

            comboBox1.Text = student.Gender;
            textBox4.Text = student.Address;
            textBox5.Text = student.Course;

            comboBox2.Text = student.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            panel1.Controls.Add(f2);
            f2.Show();
        }
        string selectedImagepath = "";
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(imagesFolder);

                string fileName = Path.GetFileName(dialog.FileName);
                string newPath = Path.Combine(imagesFolder, fileName);

                File.Copy(dialog.FileName, newPath, true);

                selectedImagepath = newPath;

                pictureBox1.Image = Image.FromFile(newPath);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string path = "students.json";
           
            List<StudentData> users; // this store all of the list in UserData
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<StudentData>>(json) ?? new List<StudentData>();

            }


            else
            {
                users = new List<StudentData>();
            }


                StudentData user = new StudentData()
                {
                    Name1 = textBox1.Text, // FirstName 
                    Name2 = textBox2.Text,
                    Name3 = textBox3.Text,
                    Birthdate = dateTimePicker1.Text,
                    Age = numericUpDown1.Text,
                    Gender = comboBox1.Text,
                    Address = textBox4.Text,
                    Course = textBox5.Text,
                    Year = comboBox2.Text,
                    ImagePath = selectedImagepath
                };
                users.Add(user);
               string  newjson = JsonSerializer.Serialize(users, new JsonSerializerOptions  
                {

                   WriteIndented = true

                });
                File.WriteAllText("students.json", newjson);
            MessageBox.Show(selectedImagepath ?? "NO IMAGE SELECTED");
            MessageBox.Show("Saved!");

            panel1.Controls.Clear();
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            panel1.Controls.Add(f2);
            f2.Show();

        }

            // json = JsonSerializer.Serialize(users, new JsonSerializerOptions
            //{

            //  WriteIndented = true

            // });

            //File.WriteAllText("user.json", json);

            // File.WriteAllText("students.json",
            //  JsonSerializer.Serialize(students));


        
    }
}
