namespace Interface
{
    partial class TaskFormTwo
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(360, 22);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(404, 72);
            label1.TabIndex = 0;
            label1.Text = "Название задачи";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label2.Location = new Point(157, 158);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 49);
            label2.TabIndex = 1;
            label2.Text = "Начало интервала";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label3.Location = new Point(683, 158);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(282, 49);
            label3.TabIndex = 2;
            label3.Text = "Конец интервала";
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(466, 351);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 49);
            label4.TabIndex = 3;
            label4.Text = "Рузультат";
            label4.Click += this.label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 52);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(669, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 52);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(490, 283);
            button1.Name = "button1";
            button1.Size = new Size(133, 65);
            button1.TabIndex = 6;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            // 
            // TaskFormTwo
            // 
            AutoScaleDimensions = new SizeF(20F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1140, 544);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            Margin = new Padding(8, 9, 8, 9);
            Name = "TaskFormTwo";
            RightToLeft = RightToLeft.No;
            Text = "TaskFormTwo";
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
        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label4!"); // Простейший код для проверки
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по textbox1!"); // Простейший код для проверки
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}