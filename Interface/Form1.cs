using System.Drawing.Text;

namespace Interface
{
    public partial class Form1 : Form
    {
        // ==============TODO==============
        // сделать меню выбора задачи (задача 1, задача 2...........................................)
        // СПРАВКА С ОПИСАНИЕМ ЗАДАЧ!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // Сосиски в ТЕСТАХ
        // КОММЕНТАТОРЫ (лайки)
        // Поля ввода писел m и n (ну или просто m или n) появляются при выборе определенных задач-ч-ч (см. задания (порно))
        // Овет в виде текста (Label), если ответов много(массив) записать через пробел
        // Ошибки обработосьян
        // На вход и выход числа целые (вроде только положительные)
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Задача 1: Находит все делители заданного числа.
        /// </summary>
        private void Divisors_Click(object sender, EventArgs e)
        {
            new TaskForm(1, "Поиск делителей числа").ShowDialog();
        }

        /// <summary>
        /// Задача 2: Находит числа, имеющие ровно 5 делителей, в заданном интервале.
        /// </summary>
        private void FiveDivisorsInterval_Euclid_Click(object sender, EventArgs e)
        {
            new TaskForm(2, "Числа с 5 делителями").ShowDialog();
        }

        /// <summary>
        /// Задача 3: Разлагает число на простые множители.
        /// </summary>
        private void Factorization_Click(object sender, EventArgs e)
        {
            new TaskForm(3, "Факторизация числа").ShowDialog();
        }

        /// <summary>
        /// Задача 4: Выводит список первых N простых чисел.
        /// </summary>
        private void ListPrimeNumbers_Click(object sender, EventArgs e)
        {
            new TaskForm(4, "Список простых чисел").ShowDialog();
        }

        /// <summary>
        /// Задача 5: Генерирует список простых чисел с использованием решета Эратосфена.
        /// </summary>
        private void ListPrimeNumbers_Eratosthenes_Click(object sender, EventArgs e)
        {
            new TaskForm(5, "Список простых чисел\n(алгоритм Эратосфена)").ShowDialog();
        }

        /// <summary>
        /// Задача 6: Вычисляет наибольший общий делитель двух чисел.
        /// </summary>
        private void GreatestCommonDivisor_Click(object sender, EventArgs e)
        {
            new TaskForm(6, "Наибольший общий делитель").ShowDialog();
        }

        /// <summary>
        /// Задача 7: Вычисляет наименьшее общее кратное двух чисел.
        /// </summary>
        private void SmallestCommonMultiple_Click(object sender, EventArgs e)
        {
            new TaskForm(7, "Наименьшее общее кратное").ShowDialog();
        }



        private void OpenTermsOfUse_Click(object sender, EventArgs e)
        {
            TermsOfUse f2 = new TermsOfUse();
            f2.ShowDialog();
        }
    }
}
