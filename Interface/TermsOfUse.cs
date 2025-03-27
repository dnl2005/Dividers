using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class TermsOfUse : Form
    {
        public TermsOfUse()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 147);
            label1.Name = "label1";
            label1.Size = new Size(603, 39);
            label1.TabIndex = 0;
            label1.Text = "Задача 1. Дано число N. Найти все его делители";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 205);
            label2.Name = "label2";
            label2.Size = new Size(1154, 39);
            label2.TabIndex = 1;
            label2.Text = "Задача 2. На интервале [m, n] найти все числа, у которых число различных делителей равно 5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 264);
            label3.Name = "label3";
            label3.Size = new Size(368, 39);
            label3.TabIndex = 2;
            label3.Text = "Задача 3. Факторизовать N.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 322);
            label4.Name = "label4";
            label4.Size = new Size(944, 78);
            label4.TabIndex = 3;
            label4.Text = "Задача 4. Построить список первых N простых чисел, используя алгоритм, \r\nоснованный на определении простого числа.\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 417);
            label5.Name = "label5";
            label5.Size = new Size(1182, 39);
            label5.TabIndex = 4;
            label5.Text = "Задача 5. Построить список первых N простых чисел, используя алгоритм Решето Эратосфена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 478);
            label6.Name = "label6";
            label6.Size = new Size(1026, 39);
            label6.TabIndex = 5;
            label6.Text = "Задача 6. Найти наибольший общий делитель N и M, используя алгоритм Эвклида\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 535);
            label7.Name = "label7";
            label7.Size = new Size(638, 39);
            label7.TabIndex = 6;
            label7.Text = "Задача 7. Найти наименьшее общее кратное N и M\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 37);
            label8.Name = "label8";
            label8.Size = new Size(579, 39);
            label8.TabIndex = 7;
            label8.Text = "Числа для ввода должны быть натуральными";
            // 
            // TermsOfUse
            // 
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1293, 722);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "TermsOfUse";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label1!"); // Простейший код для проверки
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
    }
}
