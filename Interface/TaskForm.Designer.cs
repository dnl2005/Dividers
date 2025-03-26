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
            lblInput = new Label();
            lblSecondInput = new Label();
            txtInput = new TextBox();
            txtSecondInput = new TextBox();
            Calculate = new Button();
            TaskTitle = new Label();
            result = new Label();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblInput.Location = new Point(78, 273);
            lblInput.Margin = new Padding(8, 0, 8, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(445, 72);
            lblInput.TabIndex = 1;
            lblInput.Text = "Начало интервала";
            // 
            // lblSecondInput
            // 
            lblSecondInput.AutoSize = true;
            lblSecondInput.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblSecondInput.Location = new Point(852, 273);
            lblSecondInput.Margin = new Padding(8, 0, 8, 0);
            lblSecondInput.Name = "lblSecondInput";
            lblSecondInput.Size = new Size(419, 72);
            lblSecondInput.TabIndex = 2;
            lblSecondInput.Text = "Конец интервала";

            // 
            // txtInput
            // 
            txtInput.Location = new Point(146, 372);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(301, 52);
            txtInput.TabIndex = 4;
            txtInput.TextAlign = HorizontalAlignment.Center;

            // 
            // txtSecondInput
            // 
            txtSecondInput.Location = new Point(920, 372);
            txtSecondInput.Name = "txtSecondInput";
            txtSecondInput.Size = new Size(311, 52);
            txtSecondInput.TabIndex = 5;
            txtSecondInput.TextAlign = HorizontalAlignment.Center;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Calculate.Location = new Point(561, 483);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(223, 97);
            Calculate.TabIndex = 6;
            Calculate.Text = "Найти";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // TaskTitle
            // 
            TaskTitle.Dock = DockStyle.Top;
            TaskTitle.Font = new Font("Monotype Corsiva", 48F, FontStyle.Italic, GraphicsUnit.Point, 204);
            TaskTitle.Location = new Point(0, 0);
            TaskTitle.Margin = new Padding(8, 0, 8, 0);
            TaskTitle.Name = "TaskTitle";
            TaskTitle.Size = new Size(1359, 193);
            TaskTitle.TabIndex = 0;
            TaskTitle.Text = "Название задачи";
            TaskTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // result
            // 
            result.Location = new Point(30, 583);
            result.Name = "result";
            result.Size = new Size(1278, 204);
            result.TabIndex = 7;
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(20F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1359, 796);
            Controls.Add(result);
            Controls.Add(TaskTitle);
            Controls.Add(Calculate);
            Controls.Add(txtSecondInput);
            Controls.Add(txtInput);
            Controls.Add(lblSecondInput);
            Controls.Add(lblInput);
            Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            Margin = new Padding(8, 9, 8, 9);
            Name = "TaskForm";
            RightToLeft = RightToLeft.No;
            Text = "TaskFormTwo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
        private Label lblInput;
        private Label lblSecondInput;
        private TextBox txtInput;
        private TextBox txtSecondInput;
        private Button Calculate;
        private Label TaskTitle;
        private Label result;
    }
}