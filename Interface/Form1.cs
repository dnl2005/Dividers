using System.Drawing.Text;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TaskForm("Делители числа", 1).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("Наибольший общий делитель (Эвклид)", 6).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("Наименьшее общее кратное", 7).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TaskForm("Список простых чисел", 4).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TaskForm("Факторизация", 3).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TaskForm("Список простых чисел\n(Решето Эратосфен)", 5).ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("Числа с различными делителями", 2).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           new TermsOfUse().ShowDialog();
        }
    }
}
