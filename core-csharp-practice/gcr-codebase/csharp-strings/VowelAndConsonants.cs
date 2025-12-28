using System;
using System.IO.Pipes;
class VowelAndConsonants
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        int vowels = 0;
        for(int i = 0; i < s.Length; i++)
        {
            char curr = s[i];
            if(curr == 'a' || curr == 'A' || 
               curr == 'e' || curr == 'E' ||
               curr == 'i' || curr == 'I' ||
               curr == 'o' || curr == 'O' ||
               curr == 'u' || curr == 'U')vowels++;
        }
        int cosonants = s.Length - vowels;

        Console.WriteLine("Vowels : "+vowels +"    consonants : "+cosonants);
    }
}