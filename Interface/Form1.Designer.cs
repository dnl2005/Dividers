namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            task6 = new Button();
            task7 = new Button();
            task1 = new Button();
            task4 = new Button();
            task3 = new Button();
            task5 = new Button();
            task2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // task6
            // 
            task6.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task6.Location = new Point(559, 380);
            task6.Name = "task6";
            task6.Size = new Size(414, 106);
            task6.TabIndex = 0;
            task6.Text = "Наибольший общий делитель (алгоритм Эвклида)";
            task6.UseVisualStyleBackColor = true;
            task6.Click += button1_Click;
            // 
            // task7
            // 
            task7.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task7.Location = new Point(559, 183);
            task7.Name = "task7";
            task7.Size = new Size(414, 62);
            task7.TabIndex = 1;
            task7.Text = "Наименьшее общее кратное";
            task7.UseVisualStyleBackColor = true;
            task7.Click += button2_Click;
            // 
            // task1
            // 
            task1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task1.Location = new Point(122, 283);
            task1.Name = "task1";
            task1.Size = new Size(241, 62);
            task1.TabIndex = 2;
            task1.Text = "Делители";
            task1.UseVisualStyleBackColor = true;
            task1.Click += button3_Click;
            // 
            // task4
            // 
            task4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task4.Location = new Point(377, 283);
            task4.Name = "task4";
            task4.Size = new Size(335, 62);
            task4.TabIndex = 3;
            task4.Text = "Список простых чисел";
            task4.UseVisualStyleBackColor = true;
            task4.Click += button4_Click;
            // 
            // task3
            // 
            task3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task3.Location = new Point(732, 283);
            task3.Name = "task3";
            task3.Size = new Size(241, 62);
            task3.TabIndex = 4;
            task3.Text = "Факторизация";
            task3.UseVisualStyleBackColor = true;
            task3.Click += button5_Click;
            // 
            // task5
            // 
            task5.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task5.Location = new Point(122, 380);
            task5.Name = "task5";
            task5.Size = new Size(412, 106);
            task5.TabIndex = 5;
            task5.Text = "Список простых чисел \n (алгоритм Эратосфена)";
            task5.UseVisualStyleBackColor = true;
            task5.Click += button6_Click;
            // 
            // task2
            // 
            task2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            task2.Location = new Point(120, 183);
            task2.Name = "task2";
            task2.Size = new Size(414, 62);
            task2.TabIndex = 6;
            task2.Text = "5 делителей на интервале";
            task2.UseVisualStyleBackColor = true;
            task2.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(441, 21);
            label1.Name = "label1";
            label1.Size = new Size(205, 57);
            label1.TabIndex = 7;
            label1.Text = "Делители";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(377, 93);
            label2.Name = "label2";
            label2.Size = new Size(335, 57);
            label2.TabIndex = 8;
            label2.Text = "Выберите задачу";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(56, 137, 235);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button8.ForeColor = Color.White;
            button8.Location = new Point(1050, 518);
            button8.Name = "button8";
            button8.Size = new Size(35, 43);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1097, 573);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(task2);
            Controls.Add(task5);
            Controls.Add(task3);
            Controls.Add(task4);
            Controls.Add(task1);
            Controls.Add(task7);
            Controls.Add(task6);
            Name = "Form1";
            Text = "Делители-разделители туда-сюда-смотрители";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button task6;
        private Button task7;
        private Button task1;
        private Button task4;
        private Button task3;
        private Button task5;
        private Button task2;
        private Label label1;
        private Label label2;
        private Button button8;
    }
}
