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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 42);
            label1.Name = "label1";
            label1.Size = new Size(1180, 108);
            label1.TabIndex = 0;
            label1.Text = "Делитель (или фактор) числа n - это целое число, на которое n\r\n делится без остатка.";
            label1.Click += label1_Click;
            // 
            // TermsOfUse
            // 
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1293, 722);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 24F);
            Name = "TermsOfUse";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label1!"); // Простейший код для проверки
        }
    }
}
