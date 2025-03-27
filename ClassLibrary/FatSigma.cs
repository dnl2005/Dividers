namespace ClassLibrary
{
    public static class FatSigma
    { 
        /// <summary>
        /// Метод для нахождения всех делителей числа 
        /// </summary>
        /// <param name="N"> число </param>
        /// <returns> возвращает массив делителей </returns>
        public static int[] Task1(int N)
        {
            int[] divisors = [];

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    _ = divisors.Append(i);
                }
            }

            return divisors;
        }




        /// <summary>
        /// метод для нахождения всех чисел на интервале с ровно 5 делителями
        /// </summary>
        /// <param name="m"> начало интервала </param>
        /// <param name="n"> конец интервала </param>
        /// <returns> возвращает массив чисел </returns>
        public static int[] Task2(int m, int n)
        {
            int[] result = [];

            for (int i = m; i <= n; i++)
            {
                if (CountDivisors(i) == 5)
                {
                    _ = result.Append(i);
                }
            }

            return result;
        }


        /// <summary>
        /// Метод для подсчета количества делителей у числа
        /// </summary>
        /// <param name="num"> число </param>
        /// <returns> возвращает кол-во делителей у числа, цел. число </returns>
        private static int CountDivisors(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            return count;
        }



        /// <summary>
        /// Метод для факторизации числа
        /// </summary>
        /// <param name="N"> число </param>
        /// <returns> возвращает массив простых множителей числа </returns>
        public static int[] Task3(int N)
        {
            int[] primeFactors = [];

            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    _ = primeFactors.Append(i);
                    N /= i;
                }
            }

            return primeFactors;
        }


        /// <summary>
        /// Метод для нахождения первых N простых чисел
        /// </summary>
        /// <param name="N"> кол-во чисел для нахождения </param>
        /// <returns> возвращает массив простых чисел </returns>
        public static int[] Task4(int N)
        {
            int[] primes = [];
            int count = 0;
            int num = 2;

            while (count < N)
            {
                if (IsPrime(num))
                {
                    _ = primes.Append(num);
                    count++;
                }
                num++;
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
            if (num < 2)
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
        /// Метод для нахождения первых N простых чисел по Эратосфену
        /// </summary>
        /// <param name="N"> кол-во простых чисел для нахождения </param>
        /// <returns> возвращает массив простых чисел </returns>
        public static int[] Task5(int N)
        {
            int[] primes = [];
            bool[] isPrime = new bool[N * N];
            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; primes.Length < N; p++)
            {
                if (isPrime[p])
                {
                    _ = primes.Append(p);

                    for (int i = p * p; i < isPrime.Length; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            return primes;
        }


        /// <summary>
        /// Метод для нахождения наибольшего общего делителя у 2 чисел
        /// по Эвклиду
        /// </summary>
        /// <param name="a"> число а </param>
        /// <param name="b"> число b </param>
        /// <returns> возвращает НОД, число </returns>
        public static int Task6(int a, int b)
        {
            while (b != 0)
            {
                (b, a) = (a, b % a);
            }

            return a;
        }

        /// <summary>
        /// Метод для нахождения НОК по Евклиду 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                (b, a) = (a, b % a);
            }

            return a;       
        }

        /// <summary>
        /// Метод для нахождения наименьшего общего кратного 2 чисел
        /// </summary>
        /// <param name="a">Первое целое число </param>
        /// <param name="b">Второе целое число </param>
        /// <returns>
        /// Наименьшее общее кратное чисел a и b.
        /// </returns>
        public static int Task7(int a, int b)
        {
            return a * b / FindGCD(a, b);
        }
    }
}
