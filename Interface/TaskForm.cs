using System;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;

namespace Interface
{
    public partial class TaskForm : Form
    {
        private int _taskNumber;
        public TaskForm(int taskNumber, string taskTitle)
        {
            InitializeComponent();
            _taskNumber = taskNumber;
            TaskTitle.Text = taskTitle;

            if (taskNumber == 2 || taskNumber == 6 || taskNumber == 7)
            {
                lblSecondInput.Visible = true;
                txtSecondInput.Visible = true;
            }
            else
            {
                lblSecondInput.Visible = false;
                txtSecondInput.Visible = false;
                lblInput.Text = "Число";
                lblInput.Location = new Point(585, 280);
                txtInput.Location = new Point(520, 380);
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtInput.Text, out int Value))
                {
                    MessageBox.Show("Ошибка: Введите корректное число в первое поле.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int SecondValue = 0;
                if (_taskNumber == 2 || _taskNumber == 6 || _taskNumber == 7)
                {
                    if (!int.TryParse(txtSecondInput.Text, out SecondValue))
                    {
                        MessageBox.Show("Ошибка: Введите корректное число во второе поле.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (_taskNumber == 6 || _taskNumber == 7)
                    {
                        if (SecondValue == 0)
                        {
                            MessageBox.Show("Ошибка: Второе число не может быть равно нулю.", "Ошибка вычисления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                switch (_taskNumber)
                {
                    case 1:
                        result.Text = string.Join(", ", FatSigma.Task1(Value));
                        break;

                    case 2:
                        result.Text = string.Join(", ", FatSigma.Task2(Value, SecondValue));
                        break;

                    case 3:
                        result.Text = string.Join(" * ", FatSigma.Task3(Value));
                        break;

                    case 4:
                        result.Text = string.Join(", ", FatSigma.Task4(Value));
                        break;

                    case 5:
                        result.Text = string.Join(", ", FatSigma.Task5(Value));
                        break;

                    case 6:
                        result.Text = Convert.ToString(FatSigma.Task6(Value, SecondValue));
                        break;

                    case 7:
                        result.Text = Convert.ToString(FatSigma.Task7(Value, SecondValue));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
