namespace SieveOfEratosthenes;

public class GeneratorPrimes
{
    public static int[] generatePrimes(int maxValue)
    {
        if (maxValue < 2)
            return Array.Empty<int>();
        
        PrimeManager primeManager = new PrimeManager(maxValue);
        return primeManager.GetPrimes();
    }
}
