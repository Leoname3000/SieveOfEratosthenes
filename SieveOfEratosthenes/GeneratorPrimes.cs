namespace SieveOfEratosthenes;

public class GeneratorPrimes
{
    public static int[] generatePrimes(int maxValue)
    {
        if (maxValue < 2)
            return Array.Empty<int>();

        // Объявления
        int initialSize = maxValue + 1; // Размер массива
        Boolean[] isPrime = new bool[initialSize];

        //Инициализировать массив значением true
        for (int number = 0; number < initialSize; number++)
            isPrime[number] = true;

        //Удалить числа, заведомо не являющиеся простыми
        isPrime[0] = isPrime[1] = false;

        //Отсев
        for (int number = 2; number < Math.Sqrt(initialSize) + 1; number++)
        {
            if (isPrime[number]) //Если элемент i не вычеркнут, вычеркнуть кратные ему
            {
                for (int multiple = 2 * number; multiple < initialSize; multiple += number)
                    isPrime[multiple] = false; //Кратные числа не являются простыми
            }
        }

        //Сколько простых чисел осталось?
        int primesSize = 0;
        for (int number = 0; number < initialSize; number++)
        {
            if (isPrime[number])
                primesSize++; //Приращение счетчика
        }

        int[] primes = new int[primesSize];
        //Переместить простые числа в результат
        for (int number = 0, j = 0; number < initialSize; number++)
        {
            if (isPrime[number]) //Если простое
                primes[j++] = number;
        }
        return primes; //Вернуть простые числа
    }
}
