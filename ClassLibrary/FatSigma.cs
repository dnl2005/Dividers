using System.Threading.Tasks.Sources;

namespace ClassLibrary;

public static class FatSigma
{ 
    /// <summary>
    /// Метод для нахождения всех делителей числа 
    /// </summary>
    /// <param name="N"> число </param>
    /// <returns> возвращает список делителей </returns>
    public static List<int> Task1(int number)
    {
        List<int> divisors = new List<int>(); //список делителей

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
            divisors.Add(i);
            }
        }   

        return divisors;
    }




    /// <summary>
    /// метод для нахождения всех чисел на интервале с ровно 5 делителями
    /// </summary>
    /// <param name="n"> начало интервала </param>
    /// <param name="m"> конец интервала </param>
    /// <returns> возвращает список чисел </returns>
    public static List<int> Task2(int n, int m)
    {
        List<int> result = new List<int>();//список, содержащий искомые числа

        for (int number = n; number <= m; number++)
        {
            if (Math.Sqrt(number) == (int)Math.Sqrt(number)) // если число является точным квадратом
            {
                if (DivisorsCheck(number,5)==true) // то проверяем количесво его делителей
                {
                    result.Add(number);
                }
            }
        }

        return result;
    }


    /// <summary>
    /// Метод для проверки количества делителей у числа
    /// Подразумевается, что метод принимает числа-точные квадраты
    /// </summary>
    /// <param name="number"> число </param>
    /// <param name="number_of_divisors"> заданное число делителей числа </param>
    /// <returns> возвращает true/false </returns>
    private static bool DivisorsCheck(int number, int number_of_divisors)
    {
        int count = 3; // счётчик числа натуральных делителей у числа 
                       // 1 и самого числа
        double number_sqrt = Math.Sqrt(number);
        for (int i = 2; i < number_sqrt; i++)
        {
            if (number % i == 0)
            {
                count = count + 2;
            }
            if (count > number_of_divisors)
            {
                return false;
            }
        }
        if (count == 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    /// <summary>
    /// Метод для факторизации числа
    /// </summary>
    /// <param name="number"> число </param>
    /// <returns> возвращает список простых множителей числа </returns>
    public static List<int> Task3(int number)
    {
        List<int> primeFactors = new List<int>();
        int num=number;
        while (num%2==0) // проверка делимости на 2
        {
            primeFactors.Add(2);
            num = num / 2;
        }
        double number_sqrt = Math.Sqrt(number);
        //поиск делителей больше 2
        for (int i = 3; i<= number_sqrt; i=i+2)
        {
            while (num % i == 0)
            {
                primeFactors.Add(i);
                num = num/i;
            }
        }
        //обработка случая, когда наибольший простой делитель больше корня из числа
        //22
        if (num >1 )
        {
            primeFactors.Add(num);
        }
        return primeFactors;
    }


    /// <summary>
    /// Метод для нахождения первых N простых чисел
    /// </summary>
    /// <param name="N"> кол-во чисел для нахождения </param>
    /// <returns> возвращает список простых чисел </returns>
    public static List<int> Task4(int N)
    {
        List<int>primes = new List<int>();
        int count = 1; 
        int num = 3;
        primes.Add(2); //сразу добавляем число 2 в список
                        //учитываем это, при объявлении num, count ранее
        while (count < N)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
                count++;
            }
            num=num+2;
        }

        return primes;
    }

    /// <summary>
    /// Метод, проверяющий, является число простым или нет
    /// </summary>
    /// <param name="num"> число </param>
    /// <returns> возвращает true/false </returns>
    private static bool IsPrime(int num)
    {
        if (num < 2) //отсеиваются числа меньше 2 
        {
            return false;
        }

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    /// <summary>
    /// Метод для нахождения первых n простых чисел с решето Эратосфена
    /// </summary>
    /// <param name="n">кол-во простых чисел для нахождения</param>
    /// <returns>список простых чисел</returns>
    public static List<int> Task5(int n)
    {
        if (n <= 0)
            return new List<int>();

        //возврат заготовки для малых значений n
        if (n == 1)
        {
            return new List<int> { 2 };
        }
        if (n == 2)
        {
            return new List<int> { 2, 3 };
        }
        //нахождение верхней границы решета
        int limit = (int)(n * Math.Log(n) + n * Math.Log(Math.Log(n))) + 3; 

        bool[] isPrime = new bool[limit + 1]; //создание решета
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;

        List<int> primes = new List<int> { 2 };

        for (int p = 3; p <= limit && primes.Count < n; p =p+2) //проесивание
        {
            if (isPrime[p]) 
            {
                primes.Add(p);
                for (int multiple = p * p; multiple <= limit; multiple += 2 * p)
                {
                    //отсеивание лишних чисел
                    isPrime[multiple] = false;
               
                }
            }
        }

        //обрезание списка, если вышли за границу n
        if (primes.Count > n)
        {
            primes = primes.Take(n).ToList();
        }

        return primes;
    }

    /// <summary>
    /// Находит наибольший общий делитель (НОД) двух чисел по алгоритму Евклида
    /// </summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>НОД двух чисел</returns>
    public static int Task6(int a, int b)
    {
        int t;
        while (b != 0)
        {
            t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    /// <summary>
    /// Находит наименьшее общее кратное (НОК) двух чисел
    /// </summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>НОК двух чисел</returns>
    public static int Task7(int a, int b)
    {
        int gcd = Task6(a, b);
        int lcm = a * b / gcd;
        return lcm;
     }
    
}
