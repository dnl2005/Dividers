using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface
{
    public partial class TaskForm : Form
    {
        private string taskName;
        private int taskIndex;
        private static string number;

        public TaskForm(string taskName, int taskIndex)
        {
            InitializeComponent();
            

            this.taskName = taskName;
            this.taskIndex = taskIndex;

            label1.Text = taskName;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(
                (ClientSize.Width - label1.Width) / 2,
                20
            );

            panel1.Anchor = AnchorStyles.None;

            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(
                0, 
                (label1.Location.Y + label1.Height + 20)
            );

            //PlaceCenterRes();
        }

        //private void PlaceCenterRes()
        //{
        //    textBox2.Anchor = AnchorStyles.None;
        //    textBox2.Location = new Point(
        //        (panel1.Width - textBox2.Width) / 2,
        //        label2.Location.Y + 50
        //    );
        //}

        private static bool errorDispatcher(string number)
        {
            if (!int.TryParse(number, out var n))
            {
                ShowError("Введено некорректное число (см. справку)");
                return false;
            }

            if (n <= 0)
            {
                ShowError("Число должно быть натуральным");
                return false;
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            number = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (errorDispatcher(number))
                n = int.Parse(number);
            else
                return;

            List<int> numbers = new List<int>();

            switch (taskIndex)
            {
                case 1:
                    numbers = FatSigma.Task1(n);
                    PrintList(numbers);
                    break;
                case 3:
                    numbers = FatSigma.Task3(n);
                    PrintFact(numbers);
                    break;
                case 4:
                    numbers = FatSigma.Task4(n);
                    PrintList(numbers);
                    break;
                case 5:
                    numbers = FatSigma.Task5(n);
                    PrintList(numbers);
                    break;

                default:
                    break;
            }

            
            //PlaceCenterRes();
        }

        private void PrintList(List<int> list)
        {
            string output = "";

            if (list.Count == 0)
                textBox2.Text = "Таких чисел не существует";

            for (int i = 0; i < list.Count; i++)
            {
                output += list[i];

                if (i != list.Count - 1)
                {
                    output += ", ";
                }
            }

            textBox2.Text = output;
        }

        private void PrintFact(List<int> list)
        {
            string output = "";

            for (int i = 0; i < list.Count; i++)
            {
                output += list[i];

                if (i != list.Count - 1)
                {
                    output += " * ";
                }
            }

            textBox2.Text = output;
        }

        static private void ShowError(string err)
        {
            ErrorMsg f3 = new ErrorMsg(err);
            f3.ShowDialog();
        }
    }
}
