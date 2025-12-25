using System;

class NumberChecker2
{
    public static void Main(string[] args)
    {
        int number = 216;
        int digitCount = CountDigits(number);
        int[] digits = GetDigits(number);

        Console.WriteLine("Digits: " + string.Join(", ", digits));
        Console.WriteLine("Digit count: " + digitCount);

        int sumOfDigits = SumOfDigits(digits);
        double sumOfSquares = SumOfSquares(digits);
        bool isHarshad = IsHarshad(number, digits);
        int[,] frequencyTable = GetDigitFrequency(digits);

        Console.WriteLine("Sum of digits: " + sumOfDigits);
        Console.WriteLine("Sum of squares: " + sumOfSquares);
        Console.WriteLine("Harshad number: " + isHarshad);

        Console.WriteLine("Digit frequency:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(frequencyTable[i, 0] + " -> " + frequencyTable[i, 1]);
        }
    }

    static int CountDigits(int number)
    {
        int count = 0;
        int temp = number;

        while (temp > 0)
        {
            count++;
            temp /= 10;
        }

        return count;
    }

    static int[] GetDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        return digits;
    }

    static int SumOfDigits(int[] digits)
    {
        int sum = 0;

        foreach (int digit in digits)
            sum += digit;

        return sum;
    }

    static double SumOfSquares(int[] digits)
    {
        double sum = 0;

        foreach (int digit in digits)
            sum += Math.Pow(digit, 2);

        return sum;
    }

    static bool IsHarshad(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    static int[,] GetDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
            frequency[i, 0] = i;

        foreach (int digit in digits)
            frequency[digit, 1]++;

        return frequency;
    }
}
