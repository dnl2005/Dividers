namespace Interface
{
    public partial class TaskForm
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
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(200, 45);
            label1.Name = "label1";
            label1.Size = new Size(660, 49);
            label1.TabIndex = 0;
            label1.Text = "Наибольший общий делитель";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(340, 118);
            label2.Name = "label2";
            label2.Size = new Size(341, 34);
            label2.TabIndex = 1;
            label2.Text = "Введите число для нахождения";
            label2.Click += this.label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(428, 293);
            label3.Name = "label3";
            label3.Size = new Size(130, 34);
            label3.TabIndex = 3;
            label3.Text = "Результат";
            label3.Click += this.label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(428, 242);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 4;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1045, 576);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "Наибольший Общий Делитель";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}