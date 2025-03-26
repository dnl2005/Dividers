namespace ClassLibrary
{
    public static class FatSigma
    {
        public static int[] Task1(int N)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors.ToArray();
        }

        public static int[] Task2(int m, int n)
        {
            List<int> result = new List<int>();

            for (int i = m; i <= n; i++)
            {
                if (CountDivisors(i) == 5)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

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

        public static int[] Task3(int N)
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    primeFactors.Add(i);
                    N /= i;
                }
            }

            return primeFactors.ToArray();
        }

        public static int[] Task4(int N)
        {
            List<int> primes = new List<int>();
            int count = 0;
            int num = 2;

            while (count < N)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                    count++;
                }
                num++;
            }

            return primes.ToArray();
        }

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

        public static int[] Task5(int N)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[N * N];

            for (int i = 2; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; primes.Count < N; p++)
            {
                if (isPrime[p])
                {
                    primes.Add(p);

                    for (int i = p * p; i < isPrime.Length; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            return primes.ToArray();
        }

        public static int Task6(int a, int b)
        {
            while (b != 0)
            {
                (b, a) = (a, b % a);
            }

            return a;
        }

        private static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                (b, a) = (a, b % a);
            }

            return a;
        }

        public static int Task7(int a, int b)
        {
            return a * b / FindGCD(a, b);
        }
    }

}
