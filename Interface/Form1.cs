using System.Drawing.Text;

namespace Interface
{
    public partial class Form1 : Form
    {
        // ==============TODO==============
        // ������� ���� ������ ������ (������ 1, ������ 2...........................................)
        // ������� � ��������� �����!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // ������� � ������
        // ������������ (�����)
        // ���� ����� ����� m � n (�� ��� ������ m ��� n) ���������� ��� ������ ������������ �����-�-� (��. ������� (�����))
        // ���� � ���� ������ (Label), ���� ������� �����(������) �������� ����� ������
        // ������ ������������
        // �� ���� � ����� ����� ����� (����� ������ �������������)
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ������ 1: ������� ��� �������� ��������� �����.
        /// </summary>
        private void Divisors_Click(object sender, EventArgs e)
        {
            new TaskForm(1, "����� ��������� �����").ShowDialog();
        }

        /// <summary>
        /// ������ 2: ������� �����, ������� ����� 5 ���������, � �������� ���������.
        /// </summary>
        private void FiveDivisorsInterval_Euclid_Click(object sender, EventArgs e)
        {
            new TaskForm(2, "����� � 5 ����������").ShowDialog();
        }

        /// <summary>
        /// ������ 3: ��������� ����� �� ������� ���������.
        /// </summary>
        private void Factorization_Click(object sender, EventArgs e)
        {
            new TaskForm(3, "������������ �����").ShowDialog();
        }

        /// <summary>
        /// ������ 4: ������� ������ ������ N ������� �����.
        /// </summary>
        private void ListPrimeNumbers_Click(object sender, EventArgs e)
        {
            new TaskForm(4, "������ ������� �����").ShowDialog();
        }

        /// <summary>
        /// ������ 5: ���������� ������ ������� ����� � �������������� ������ ����������.
        /// </summary>
        private void ListPrimeNumbers_Eratosthenes_Click(object sender, EventArgs e)
        {
            new TaskForm(5, "������ ������� �����\n(�������� ����������)").ShowDialog();
        }

        /// <summary>
        /// ������ 6: ��������� ���������� ����� �������� ���� �����.
        /// </summary>
        private void GreatestCommonDivisor_Click(object sender, EventArgs e)
        {
            new TaskForm(6, "���������� ����� ��������").ShowDialog();
        }

        /// <summary>
        /// ������ 7: ��������� ���������� ����� ������� ���� �����.
        /// </summary>
        private void SmallestCommonMultiple_Click(object sender, EventArgs e)
        {
            new TaskForm(7, "���������� ����� �������").ShowDialog();
        }



        private void OpenTermsOfUse_Click(object sender, EventArgs e)
        {
            TermsOfUse f2 = new TermsOfUse();
            f2.ShowDialog();
        }
    }
}
