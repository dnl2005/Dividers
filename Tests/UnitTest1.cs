using ClassLibrary;

namespace UnitTests;
[TestClass]
public class Test
{
    [TestMethod]
    public void Task1_Tst()
    {
        int number = 100;
        List <int> expected = new List<int> { 1, 2, 4, 5, 10, 20, 25, 50, 100 };
        List <int> result = FatSigma.Task1(number);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task2_Test()
    {
        int a = 1;
        int b = 1000;
        List <int> expected = new List<int> { 16, 81, 625 };
        List <int> result = FatSigma.Task2(a, b);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task3_Test()
    {
        int number = 100;
        List <int> expected = new List<int> { 2, 2, 5, 5 };
        List <int> result = FatSigma.Task3(number);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void Task3_Test625()
    {
        int number = 625;
        List<int> expected = new List<int> { 5, 5, 5, 5 };
        List<int> result = FatSigma.Task3(number);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task3_Test1000()
    {
        int number = 1000;
        List<int> expected = new List<int> { 2, 2,2, 5, 5, 5 };
        List<int> result = FatSigma.Task3(number);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Task4_Test()
    {
        int n = 10;
        List <int> expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        List <int> result = FatSigma.Task4(n);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task5_Test()
    {
        int n = 10;
        List <int> expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        List <int> result = FatSigma.Task5(n);
        Assert.AreEqual(expected.Count, result.Count);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task6_Test()
    {
        int a = 40;
        int b = 100;
        int expected = 20;
        int result = FatSigma.Task6(a, b);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Task7_Test()
    {
        int a = 40;
        int b = 100;
        int expected = 200;
        int result = FatSigma.Task7(a, b);
        Assert.AreEqual(expected, result);
    }
}