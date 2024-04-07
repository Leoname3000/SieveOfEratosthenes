namespace SieveOfEratosthenes.Tests;

public class UnitTest1
{
    [Fact]
    public void TestMax0()
    {
        int[] primes = GeneratorPrimes.generatePrimes(0);
        int[] expected = Array.Empty<int>();
        Assert.True(Enumerable.SequenceEqual(expected, primes));
    }
    
    [Fact]
    public void TestMax1()
    {
        int[] primes = GeneratorPrimes.generatePrimes(1);
        int[] expected = Array.Empty<int>();
        Assert.True(Enumerable.SequenceEqual(expected, primes));
    }
    
    [Fact]
    public void TestMax2()
    {
        int[] primes = GeneratorPrimes.generatePrimes(2);
        int[] expected = { 2 };
        Assert.True(Enumerable.SequenceEqual(expected, primes));
    }
    
    [Fact]
    public void TestMax100()
    {
        int[] primes = GeneratorPrimes.generatePrimes(100);
        int[] expected = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        Assert.True(Enumerable.SequenceEqual(expected, primes));
    }
    
    [Fact]
    public void TestMaxNegative()
    {
        int[] primes = GeneratorPrimes.generatePrimes(-100);
        int[] expected = Array.Empty<int>();
        Assert.True(Enumerable.SequenceEqual(expected, primes));
    }
}