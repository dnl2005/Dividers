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
            new TaskForm("�������� �����", 1).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("���������� ����� �������� (������)", 6).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("���������� ����� �������", 7).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TaskForm("������ ������� �����", 4).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TaskForm("������������", 3).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TaskForm("������ ������� �����\n(������ ���������)", 5).ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new TaskFormTwo("����� � ���������� ����������", 2).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           new TermsOfUse().ShowDialog();
        }
    }
}
