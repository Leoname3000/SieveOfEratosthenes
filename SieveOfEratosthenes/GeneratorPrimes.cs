namespace SieveOfEratosthenes;

public class GeneratorPrimes
{
    public static int[] generatePrimes(int maxValue)
    {
        if (maxValue >= 2) // Единственно допустимый случай
        {
            // Объявления
            int initialSize = maxValue + 1; // Размер массива
            Boolean[] isPrime = new bool[initialSize];
            int i;

            //Инициализировать массив значением true
            for (i = 0; i < initialSize; i++)
                isPrime[i] = true;

            //Удалить числа, заведомо не являющиеся простыми
            isPrime[0] = isPrime[1] = false;

            //Отсев
            int j;
            for (i = 2; i < Math.Sqrt(initialSize) + 1; i++)
            {
                if (isPrime[i]) //Если элемент i не вычеркнут, вычеркнуть кратные ему
                {
                    for (j = 2 * i; j < initialSize; j += i)
                        isPrime[j] = false; //Кратные числа не являются простыми
                }
            }

            //Сколько простых чисел осталось?
            int primesSize = 0;
            for (i = 0; i < initialSize; i++)
            {
                if (isPrime[i])
                    primesSize++; //Приращение счетчика
            }

            int[] primes = new int[primesSize];
            //Переместить простые числа в результат
            for (i = 0, j = 0; i < initialSize; i++)
            {
                if (isPrime[i]) //Если простое
                    primes[j++] = i;
            }
            return primes; //Вернуть простые числа
        }
        else //maxValue < 2
            return new int[0]; //Вернуть пустой массив
    }
}
