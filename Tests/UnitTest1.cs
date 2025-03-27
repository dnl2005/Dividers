using ClassLibrary;
namespace Tests;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Task1_test()
    {
        int number = 100;
        int[] divisors = FatSigma.Task1(number);
        int[] expected_divisors = [1, 2, 4, 5, 10, 20, 25, 50, 100];
        Assert.AreEqual(expected_divisors.Length, divisors.Length);
        CollectionAssert.AreEqual(expected_divisors, divisors);
    }


    [TestMethod]
    public void Task2_test()
    {
        int a = 1;
        int b = 1000;
        int[] result = FatSigma.Task2(a, b);
        int[] expected_divisors = [16, 81, 625];
        Assert.AreEqual(expected_divisors.Length, result.Length);
        CollectionAssert.AreEqual(expected_divisors, result);
    }

    [TestMethod]
    public void Task3_test()
    {
        int number = 100;
        int[] primeFactors = FatSigma.Task3(number);
        int[] expected_divisors = [2, 2, 5, 5];
        Assert.AreEqual(expected_divisors.Length, primeFactors.Length);
        CollectionAssert.AreEqual(expected_divisors, primeFactors);
    }

    [TestMethod]
    public void Task4_test()
    {
        int n = 10;
        int[] primes = FatSigma.Task4(n);
        int[] expected_divisors = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
        Assert.AreEqual(expected_divisors.Length, primes.Length);
        CollectionAssert.AreEqual(expected_divisors, primes);
    }

    [TestMethod]
    public void Task5_test()
    {
        int n = 10;
        int[] primes = FatSigma.Task5(n);
        int[] expected_divisors = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
        Assert.AreEqual(expected_divisors.Length, primes.Length);
        CollectionAssert.AreEqual(expected_divisors, primes);
    }


    [TestMethod]
    public void Task6_test()
    {
        int a = 40;
        int b = 100;
        int gcd = FatSigma.Task6(a, b);
        int expected_gcd = 20;
        Assert.AreEqual(expected_gcd,gcd);
    }

    [TestMethod]
    public void Task7_test()
    {
        int a = 40;
        int b = 100;
        int lcm = FatSigma.Task7(a, b);
        int expected_lcm = 200;
        Assert.AreEqual(expected_lcm, lcm);
    }

}