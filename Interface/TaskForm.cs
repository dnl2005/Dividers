﻿using System;
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
                40
            );

            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(
                (ClientSize.Width - label4.Width) / 2,
                (ClientSize.Height - 100)
            );
        }

        private static int errorDispatcher(string number)
        {
            if (!int.TryParse(number, out var n))
                MessageBox.Show("Введено некорректное число (см. справку)");

            return n;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            number = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = errorDispatcher(number);
            int[] numbers = Array.Empty<int>();

            switch (taskIndex)
            {
                case 1:
                    numbers = FatSigma.Task1(n);
                    break;
                case 3:
                    numbers = FatSigma.Task3(n);
                    break;
                case 4:
                    numbers = FatSigma.Task4(n);
                    break;
                case 5:
                    numbers = FatSigma.Task5(n);
                    break;

                default:
                    break;
            }
            PrintList(numbers);
        }

        private void PrintList(int[] list)
        {
            string output = "";

            foreach (var item in list)
            {
                if (list.Length == 1 || item.Equals(list.Last()))
                    output += item;

                output += item + ", ";
            }

            label4.Text = output;
        }
    }
}
