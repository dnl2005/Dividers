﻿namespace Interface
{
    partial class TaskForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(686, 72);
            label1.TabIndex = 0;
            label1.Text = "Наибольший общий делитель";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(312, 114);
            label2.Name = "label2";
            label2.Size = new Size(488, 49);
            label2.TabIndex = 1;
            label2.Text = "Введите число для нахождения";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(477, 365);
            label3.Name = "label3";
            label3.Size = new Size(175, 45);
            label3.TabIndex = 2;
            label3.Text = "Результат";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(468, 245);
            button1.Name = "button1";
            button1.Size = new Size(168, 63);
            button1.TabIndex = 3;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 27);
            textBox1.TabIndex = 4;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1111, 591);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label1!"); // Простейший код для проверки
        }
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label2!"); // Простейший код для проверки
        }
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label3!"); // Простейший код для проверки
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
    }
}