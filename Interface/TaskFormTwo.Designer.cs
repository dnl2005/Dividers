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
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(385, 45);
            label1.Name = "label1";
            label1.Size = new Size(154, 72);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label2.Location = new Point(213, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 49);
            label2.TabIndex = 1;
            label2.Text = "Число N";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            textBox1.Location = new Point(190, 56);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 52);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            textBox2.Location = new Point(498, 56);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 52);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label3.Location = new Point(520, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 49);
            label3.TabIndex = 4;
            label3.Text = "Число M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            label4.Location = new Point(360, 249);
            label4.Name = "label4";
            label4.Size = new Size(189, 49);
            label4.TabIndex = 5;
            label4.Text = "Результат";
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(331, 151);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(237, 75);
            button1.TabIndex = 7;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(25, 125);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 475);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(textBox3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel3.Location = new Point(0, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 178);
            panel3.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Top;
            textBox3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(0, 0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(893, 91);
            textBox3.TabIndex = 6;
            textBox3.WordWrap = false;
            // 
            // TaskFormTwo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(931, 616);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskFormTwo";
            Text = "TaskFormTwo";
            Load += TaskFormTwo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox3;
    }
}