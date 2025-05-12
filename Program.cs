using NUnit.Framework;
using System;

public class FizzBuzz
{
    public string GetFizzBuzzResult(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return number.ToString();
    }

    public static void Main(string[] args)
    {
        FizzBuzz fb = new FizzBuzz();
        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine(fb.GetFizzBuzzResult(i));
        }

        FizzBuzzTest testFixture = new FizzBuzzTest();
        testFixture.Setup();
        testFixture.GetFizzBuzzResult_DivisibleBy3And5_ReturnsFizzBuzz();
        testFixture.GetFizzBuzzResult_DivisibleBy3_ReturnsFizz();
        testFixture.GetFizzBuzzResult_DivisibleBy5_ReturnsBuzz();
        testFixture.GetFizzBuzzResult_NotDivisibleBy3Or5_ReturnsNumber();

        Console.WriteLine("\nNUnit tests would pass if executed.");
    }
}

[TestFixture]
public class FizzBuzzTest
{
    private FizzBuzz _fizzBuzz;

    [SetUp]
    public void Setup()
    {
        _fizzBuzz = new FizzBuzz();
    }

    [Test]
    public void GetFizzBuzzResult_DivisibleBy3And5_ReturnsFizzBuzz()
    {
        Assert.AreEqual("FizzBuzz", _fizzBuzz.GetFizzBuzzResult(15));
    }

    [Test]
    public void GetFizzBuzzResult_DivisibleBy3_ReturnsFizz()
    {
        Assert.AreEqual("Fizz", _fizzBuzz.GetFizzBuzzResult(9));
    }

    [Test]
    public void GetFizzBuzzResult_DivisibleBy5_ReturnsBuzz()
    {
        Assert.AreEqual("Buzz", _fizzBuzz.GetFizzBuzzResult(10));
    }

    [Test]
    public void GetFizzBuzzResult_NotDivisibleBy3Or5_ReturnsNumber()
    {
        Assert.AreEqual("7", _fizzBuzz.GetFizzBuzzResult(7));
    }
}