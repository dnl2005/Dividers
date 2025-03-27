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
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(259, 105);
            button1.Name = "button1";
            button1.Size = new Size(201, 51);
            button1.TabIndex = 2;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(284, 178);
            label2.Name = "label2";
            label2.Size = new Size(150, 39);
            label2.TabIndex = 3;
            label2.Text = "Результат";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(235, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 35);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(301, 1);
            label3.Name = "label3";
            label3.Size = new Size(121, 39);
            label3.TabIndex = 5;
            label3.Text = "Число N";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(333, 233);
            label4.Name = "label4";
            label4.Size = new Size(0, 39);
            label4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(302, 20);
            label1.Name = "label1";
            label1.Size = new Size(126, 57);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 450);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 370);
            panel2.TabIndex = 8;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(716, 450);
            Controls.Add(panel1);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}