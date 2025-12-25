using System;

class NumberChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Digits: " + string.Join(", ", digits));
        Console.WriteLine("Digit count: " + digits.Length);

        Console.WriteLine("Duck number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong number: " + IsArmstrong(number, digits));

        int largest;
        int secondLargest;
        FindLargestTwo(digits, out largest, out secondLargest);

        int smallest;
        int secondSmallest;
        FindSmallestTwo(digits, out smallest, out secondSmallest);

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second largest: " + secondLargest);
        Console.WriteLine("Smallest: " + smallest);
        Console.WriteLine("Second smallest: " + secondSmallest);
    }

    static int[] GetDigits(int number)
    {
        string text = number.ToString();
        int[] digits = new int[text.Length];

        for (int i = 0; i < text.Length; i++)
            digits[i] = text[i] - '0';

        return digits;
    }

    static bool IsDuckNumber(int[] digits)
    {
        if (digits[0] == 0)
            return false;

        foreach (int digit in digits)
            if (digit == 0)
                return true;

        return false;
    }

    static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        foreach (int digit in digits)
        {
            int value = 1;
            for (int i = 0; i < power; i++)
                value *= digit;

            sum += value;
        }

        return sum == number;
    }

    static void FindLargestTwo(int[] digits, out int largest, out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
    }

    static void FindSmallestTwo(int[] digits, out int smallest, out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
    }
}
