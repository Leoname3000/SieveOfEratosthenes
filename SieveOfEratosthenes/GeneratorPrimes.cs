namespace SieveOfEratosthenes;

public class GeneratorPrimes
{
    public static int[] generatePrimes(int maxValue)
    {
        if (maxValue < 2)
            return Array.Empty<int>();
        
        Boolean[] isPrime = new bool[maxValue + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;

        for (int number = 2; number < Math.Sqrt(maxValue + 1) + 1; number++)
        {
            if (isPrime[number])
            {
                for (int multiple = 2 * number; multiple <= maxValue; multiple += number)
                    isPrime[multiple] = false;
            }
        }

        List<int> primes = new List<int>();
        for (int number = 0; number <= maxValue; number++)
        {
            if (isPrime[number])
                primes.Add(number);
        }
        return primes.ToArray();
    }
}
