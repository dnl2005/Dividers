namespace Interface
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(290, 140);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(243, 68);
            button1.TabIndex = 2;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(325, 237);
            label2.Name = "label2";
            label2.Size = new Size(189, 49);
            label2.TabIndex = 3;
            label2.Text = "Результат";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(269, 57);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 42);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(344, 1);
            label3.Name = "label3";
            label3.Size = new Size(152, 49);
            label3.TabIndex = 5;
            label3.Text = "Число N";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(345, 27);
            label1.Name = "label1";
            label1.Size = new Size(154, 72);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 600);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 107);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 493);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(textBox2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel3.Location = new Point(0, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(818, 178);
            panel3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(818, 91);
            textBox2.TabIndex = 6;
            textBox2.WordWrap = false;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(818, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
    }
}