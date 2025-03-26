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
            GreatestCommonDivisor = new Button();
            SmallestCommonMultiple = new Button();
            Divisors = new Button();
            ListPrimeNumbers = new Button();
            Factorization = new Button();
            ListPrimeNumbers_Eratosthenes = new Button();
            FiveDivisorsInterval_Euclid = new Button();
            label1 = new Label();
            label2 = new Label();
            OpenTermsOfUse = new Button();
            SuspendLayout();
            // 
            // GreatestCommonDivisor
            // 
            GreatestCommonDivisor.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            GreatestCommonDivisor.Location = new Point(139, 244);
            GreatestCommonDivisor.Margin = new Padding(3, 4, 3, 4);
            GreatestCommonDivisor.Name = "GreatestCommonDivisor";
            GreatestCommonDivisor.Size = new Size(471, 83);
            GreatestCommonDivisor.TabIndex = 0;
            GreatestCommonDivisor.Text = "Наибольший общий делитель";
            GreatestCommonDivisor.UseVisualStyleBackColor = true;
            GreatestCommonDivisor.Click += GreatestCommonDivisor_Click;
            // 
            // SmallestCommonMultiple
            // 
            SmallestCommonMultiple.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            SmallestCommonMultiple.Location = new Point(639, 244);
            SmallestCommonMultiple.Margin = new Padding(3, 4, 3, 4);
            SmallestCommonMultiple.Name = "SmallestCommonMultiple";
            SmallestCommonMultiple.Size = new Size(473, 83);
            SmallestCommonMultiple.TabIndex = 1;
            SmallestCommonMultiple.Text = "Наименьшее общее кратное";
            SmallestCommonMultiple.UseVisualStyleBackColor = true;
            SmallestCommonMultiple.Click += SmallestCommonMultiple_Click;
            // 
            // Divisors
            // 
            Divisors.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Divisors.Location = new Point(139, 377);
            Divisors.Margin = new Padding(3, 4, 3, 4);
            Divisors.Name = "Divisors";
            Divisors.Size = new Size(275, 83);
            Divisors.TabIndex = 2;
            Divisors.Text = "Делители";
            Divisors.UseVisualStyleBackColor = true;
            Divisors.Click += Divisors_Click;
            // 
            // ListPrimeNumbers
            // 
            ListPrimeNumbers.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ListPrimeNumbers.Location = new Point(448, 377);
            ListPrimeNumbers.Margin = new Padding(3, 4, 3, 4);
            ListPrimeNumbers.Name = "ListPrimeNumbers";
            ListPrimeNumbers.Size = new Size(363, 83);
            ListPrimeNumbers.TabIndex = 3;
            ListPrimeNumbers.Text = "Список простых чисел";
            ListPrimeNumbers.UseVisualStyleBackColor = true;
            ListPrimeNumbers.Click += ListPrimeNumbers_Click;
            // 
            // Factorization
            // 
            Factorization.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Factorization.Location = new Point(837, 377);
            Factorization.Margin = new Padding(3, 4, 3, 4);
            Factorization.Name = "Factorization";
            Factorization.Size = new Size(275, 83);
            Factorization.TabIndex = 4;
            Factorization.Text = "Факторизация";
            Factorization.UseVisualStyleBackColor = true;
            Factorization.Click += Factorization_Click;
            // 
            // ListPrimeNumbers_Eratosthenes
            // 
            ListPrimeNumbers_Eratosthenes.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ListPrimeNumbers_Eratosthenes.Location = new Point(139, 507);
            ListPrimeNumbers_Eratosthenes.Margin = new Padding(3, 4, 3, 4);
            ListPrimeNumbers_Eratosthenes.Name = "ListPrimeNumbers_Eratosthenes";
            ListPrimeNumbers_Eratosthenes.Size = new Size(471, 141);
            ListPrimeNumbers_Eratosthenes.TabIndex = 5;
            ListPrimeNumbers_Eratosthenes.Text = "Список простых чисел \n (алгоритм Эратосфена)";
            ListPrimeNumbers_Eratosthenes.UseVisualStyleBackColor = true;
            ListPrimeNumbers_Eratosthenes.Click += ListPrimeNumbers_Eratosthenes_Click;
            // 
            // FiveDivisorsInterval_Euclid
            // 
            FiveDivisorsInterval_Euclid.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            FiveDivisorsInterval_Euclid.Location = new Point(639, 507);
            FiveDivisorsInterval_Euclid.Margin = new Padding(3, 4, 3, 4);
            FiveDivisorsInterval_Euclid.Name = "FiveDivisorsInterval_Euclid";
            FiveDivisorsInterval_Euclid.Size = new Size(473, 141);
            FiveDivisorsInterval_Euclid.TabIndex = 6;
            FiveDivisorsInterval_Euclid.Text = "5 делителей на интервале (алгоритм Эвклида)";
            FiveDivisorsInterval_Euclid.UseVisualStyleBackColor = true;
            FiveDivisorsInterval_Euclid.Click += FiveDivisorsInterval_Euclid_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(504, 28);
            label1.Name = "label1";
            label1.Size = new Size(255, 72);
            label1.TabIndex = 7;
            label1.Text = "Делители";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(431, 124);
            label2.Name = "label2";
            label2.Size = new Size(417, 72);
            label2.TabIndex = 8;
            label2.Text = "Выберите задачу";
            // 
            // OpenTermsOfUse
            // 
            OpenTermsOfUse.BackColor = Color.FromArgb(56, 137, 235);
            OpenTermsOfUse.FlatAppearance.BorderSize = 0;
            OpenTermsOfUse.FlatStyle = FlatStyle.Flat;
            OpenTermsOfUse.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            OpenTermsOfUse.ForeColor = Color.White;
            OpenTermsOfUse.Location = new Point(1200, 691);
            OpenTermsOfUse.Margin = new Padding(3, 4, 3, 4);
            OpenTermsOfUse.Name = "OpenTermsOfUse";
            OpenTermsOfUse.Size = new Size(40, 57);
            OpenTermsOfUse.TabIndex = 9;
            OpenTermsOfUse.Text = "?";
            OpenTermsOfUse.UseVisualStyleBackColor = false;
            OpenTermsOfUse.Click += OpenTermsOfUse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1254, 764);
            Controls.Add(OpenTermsOfUse);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FiveDivisorsInterval_Euclid);
            Controls.Add(ListPrimeNumbers_Eratosthenes);
            Controls.Add(Factorization);
            Controls.Add(ListPrimeNumbers);
            Controls.Add(Divisors);
            Controls.Add(SmallestCommonMultiple);
            Controls.Add(GreatestCommonDivisor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Делители-разделители туда-сюда-смотрители";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GreatestCommonDivisor;
        private Button SmallestCommonMultiple;
        private Button Divisors;
        private Button ListPrimeNumbers;
        private Button Factorization;
        private Button ListPrimeNumbers_Eratosthenes;
        private Button FiveDivisorsInterval_Euclid;
        private Label label1;
        private Label label2;
        private Button OpenTermsOfUse;
    }
}
