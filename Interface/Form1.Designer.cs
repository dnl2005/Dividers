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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(122, 183);
            button1.Name = "button1";
            button1.Size = new Size(412, 62);
            button1.TabIndex = 0;
            button1.Text = "Наибольший общий делитель";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(559, 183);
            button2.Name = "button2";
            button2.Size = new Size(414, 62);
            button2.TabIndex = 1;
            button2.Text = "Наименьшее общее кратное";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.Location = new Point(122, 283);
            button3.Name = "button3";
            button3.Size = new Size(241, 62);
            button3.TabIndex = 2;
            button3.Text = "Делители";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button4.Location = new Point(392, 283);
            button4.Name = "button4";
            button4.Size = new Size(318, 62);
            button4.TabIndex = 3;
            button4.Text = "Список простых чисел";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button5.Location = new Point(732, 283);
            button5.Name = "button5";
            button5.Size = new Size(241, 62);
            button5.TabIndex = 4;
            button5.Text = "Факторизация";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button6.Location = new Point(122, 380);
            button6.Name = "button6";
            button6.Size = new Size(412, 106);
            button6.TabIndex = 5;
            button6.Text = "Список простых чисел \n (алгоритм Эратосфена)";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button7.Location = new Point(559, 380);
            button7.Name = "button7";
            button7.Size = new Size(414, 106);
            button7.TabIndex = 6;
            button7.Text = "5 делителей на интервале (алгоритм Эвклида)";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
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
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Делители-разделители туда-сюда-смотрители";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
        private Button button8;
    }
}
