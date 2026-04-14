namespace Student_Registration_form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            button4 = new Button();
            label3 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 530);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(27, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(139, 95);
            label4.Name = "label4";
            label4.Size = new Size(72, 42);
            label4.TabIndex = 14;
            label4.Text = "Student \nList";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 30F);
            button4.Location = new Point(140, 30);
            button4.Name = "button4";
            button4.Size = new Size(67, 62);
            button4.TabIndex = 13;
            button4.Text = "≡";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 101);
            label3.Name = "label3";
            label3.Size = new Size(68, 42);
            label3.TabIndex = 12;
            label3.Text = "Add \nStudent";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(35, 11);
            button3.Name = "button3";
            button3.Size = new Size(53, 84);
            button3.TabIndex = 11;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 537);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form2";
            Text = "Insert";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button button4;
        private Label label3;
        private Button button3;
        private Button button1;
    }
}