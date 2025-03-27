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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(337, 34);
            label1.Name = "label1";
            label1.Size = new Size(126, 57);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label2.Location = new Point(186, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 39);
            label2.TabIndex = 1;
            label2.Text = "Число N";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            textBox1.Location = new Point(166, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 43);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            textBox2.Location = new Point(436, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 43);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label3.Location = new Point(455, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 39);
            label3.TabIndex = 4;
            label3.Text = "Число M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label4.Location = new Point(315, 187);
            label4.Name = "label4";
            label4.Size = new Size(150, 39);
            label4.TabIndex = 5;
            label4.Text = "Результат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label5.Location = new Point(341, 268);
            label5.Name = "label5";
            label5.Size = new Size(0, 39);
            label5.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(290, 113);
            button1.Name = "button1";
            button1.Size = new Size(207, 56);
            button1.TabIndex = 7;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(22, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 356);
            panel1.TabIndex = 8;
            // 
            // TaskFormTwo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(815, 462);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "TaskFormTwo";
            Text = "TaskFormTwo";
            Load += TaskFormTwo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Panel panel1;
    }
}