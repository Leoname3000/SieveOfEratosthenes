namespace SieveOfEratosthenes;

public class PrimeManager
{
    private readonly Boolean[] _isPrime;
    
    public PrimeManager(int maxValue)
    {
        _isPrime = new bool[maxValue + 1];
        Array.Fill(_isPrime, true);
        _isPrime[0] = _isPrime[1] = false;
        
        FilterPrimes();
    }

    private void FilterPrimes()
    {
        for (int number = 2; number < Math.Sqrt(_isPrime.Length) + 1; number++)
            if (_isPrime[number])
                for (int multiple = 2 * number; multiple <= _isPrime.Length - 1; multiple += number)
                    _isPrime[multiple] = false;
    }

    public int[] GetPrimes()
    {
        var result = new List<int>();
        for (int number = 0; number < _isPrime.Length; number++)
            if (_isPrime[number])
                result.Add(number);

        return result.ToArray();
    }
}