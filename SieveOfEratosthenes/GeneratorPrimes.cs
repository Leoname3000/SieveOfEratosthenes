namespace SieveOfEratosthenes;

public class GeneratorPrimes
{
    public static int[] generatePrimes(int maxValue)
    {
        if (maxValue < 2)
            return Array.Empty<int>();

        int initialSize = maxValue + 1;
        Boolean[] isPrime = new bool[initialSize];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false;

        for (int number = 2; number < Math.Sqrt(initialSize) + 1; number++)
        {
            if (isPrime[number])
            {
                for (int multiple = 2 * number; multiple < initialSize; multiple += number)
                    isPrime[multiple] = false;
            }
        }

        int primesSize = 0;
        for (int number = 0; number < initialSize; number++)
        {
            if (isPrime[number])
                primesSize++;
        }

        int[] primes = new int[primesSize];
        for (int number = 0, j = 0; number < initialSize; number++)
        {
            if (isPrime[number])
                primes[j++] = number;
        }
        return primes;
    }
}
