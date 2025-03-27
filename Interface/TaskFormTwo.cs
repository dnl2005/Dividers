using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface
{
    public partial class TaskFormTwo : Form
    {
        private string taskName;
        private int taskIndex;
        private static string numberN;
        private static string numberM;

        public TaskFormTwo(string taskName, int taskIndex)
        {
            InitializeComponent();
            this.taskName = taskName;
            this.taskIndex = taskIndex;

            label1.Text = taskName;
        }

        private void TaskFormTwo_Load(object sender, EventArgs e)
        {
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(
                (ClientSize.Width - label1.Width) / 2,
                30
            );

            panel1.Anchor = AnchorStyles.None;

            PlaceCenterRes();
        }

        private void PlaceCenterRes()
        {
            label5.Anchor = AnchorStyles.None;
            label5.Location = new Point(
                (panel1.Width - label5.Width) / 2,
                label4.Location.Y + 50
            );
        }

        private static int errorDispatcher(string number)
        {
            if (!int.TryParse(number, out var n))
            {
                MessageBox.Show("Введено некорректное число (см. справку)");
            }

            return n;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numberN = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numberM = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = errorDispatcher(numberN);
            int m = errorDispatcher(numberM);
            List<int> numbers = new List<int>();
            int number = 0;

            switch (taskIndex)
            {
                case 2:
                    numbers = FatSigma.Task2(n, m);
                    PrintList(numbers);
                    PlaceCenterRes();
                    break;
                case 6:
                    number = FatSigma.Task6(n, m);
                    PrintInt(number);
                    PlaceCenterRes();
                    break;
                case 7:
                    number = FatSigma.Task7(n, m);
                    PrintInt(number);
                    PlaceCenterRes();
                    break;

                default:
                    break;
            }
        }

        private void PrintList(List<int> list)
        {
            string output = "";

            for (int i = 0; i < list.Count; i++)
            {
                output += list[i];

                if (i != list.Count - 1)
                    output += ", ";
            }

            label5.Text = output;
        }

        private void PrintInt(int number)
        {
            label5.Text = number.ToString();
        }
    }
}
