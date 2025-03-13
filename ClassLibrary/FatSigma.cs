namespace ClassLibrary
{
    public static class FatSigma
    {
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
