using System;

class OTPGenerator
{
    static void Main(string[] args)
    {
        int[] otps = new int[10];
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }
        bool isUnique = AreOTPsUnique(otps);

        Console.WriteLine("\nAre generated OTPs unique? " + isUnique);
    }
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);  
    }
    public static bool AreOTPsUnique(int[] arr)
    {
        int first = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != first)
            {
                return true;
            }
        }
        return false;
    }
}
