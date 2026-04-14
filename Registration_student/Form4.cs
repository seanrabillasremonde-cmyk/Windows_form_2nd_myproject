using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string path = "students.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<StudentData> users = JsonSerializer.Deserialize<List<StudentData>>(json) ?? new List<StudentData>();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = users;

                DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
                linkColumn.HeaderText = "View";
                linkColumn.Name = "View";
                linkColumn.Text = "Open";
                linkColumn.UseColumnTextForLinkValue = true;

                dataGridView1.Columns.Add(linkColumn);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;

            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoScaleMode = AutoScaleMode.None;
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(0);
            panel1.Margin = new Padding(0);

            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "View")
            {
                StudentData selected = (StudentData)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                // Open new form
                Form5 f5 = new Form5(selected);
                panel1.Controls.Clear();
                f5.TopLevel = false;
                f5.FormBorderStyle = FormBorderStyle.None;

                this.Dock = DockStyle.Fill;
                this.FormBorderStyle = FormBorderStyle.None;
                this.AutoScaleMode = AutoScaleMode.None;
                panel1.Dock = DockStyle.Fill;
                panel1.Padding = new Padding(0);
                panel1.Margin = new Padding(0);
               
                panel1.Controls.Add(f5);

                f5.Show();
            }
        }
    }
    
}
