using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
class EduQuiz
{
    public static void Main(String[] args)
    {
        int[]correct = {2,2,3,3,3,2,4,3,4,3};        
        string[][] arr =
        {
            new string[]
            {
                "1. Which of the following runs automatically when an object is created?",
                "A. Method",
                "B. Constructor",
                "C. Destructor",
                "D. Static block",
                "Correct: B"
            },

            new string[]
            {
                "2. What is constructor overloading?",
                "A. Multiple classes in one program",
                "B. Multiple constructors with different parameters",
                "C. Calling a constructor manually",
                "D. Defining constructor inside methods",
                "Correct: B"
            },

            new string[]
            {
                "3. Which keyword is used for class (static) variables?",
                "A. var",
                "B. this",
                "C. static",
                "D. const",
                "Correct: C"
            },

            new string[]
            {
                "4. Instance variables belong to:",
                "A. Class",
                "B. Compiler",
                "C. Each object separately",
                "D. Namespace",
                "Correct: C"
            },

            new string[]
            {
                "5. Which constructor runs only once per class?",
                "A. Default constructor",
                "B. Copy constructor",
                "C. Static constructor",
                "D. Parameterized constructor",
                "Correct: C"
            },

            new string[]
            {
                "6. What is the default value of an unassigned string array element?",
                "A. \"\" (empty string)",
                "B. null",
                "C. undefined",
                "D. 0",
                "Correct: B"
            },

            new string[]
            {
                "7. Which method checks if a string is null or whitespace?",
                "A. string.Check()",
                "B. string.Empty()",
                "C. string.IsNull()",
                "D. string.IsNullOrWhiteSpace()",
                "Correct: D"
            },

            new string[]
            {
                "8. What happens if no constructor is defined?",
                "A. Object cannot be created",
                "B. Program crashes",
                "C. C# automatically creates a default constructor",
                "D. Class becomes static",
                "Correct: C"
            },

            new string[]
            {
                "9. Static members are accessed using:",
                "A. Object name",
                "B. Base class",
                "C. Constructor",
                "D. Class name",
                "Correct: D"
            },

            new string[]
            {
                "10. Which is true about arrays in C#?",
                "A. Arrays grow automatically",
                "B. Index starts from 1",
                "C. Arrays store same data type and have fixed size",
                "D. Arrays are always dynamic",
                "Correct: C"
            }
        };

        int score = 0;
        for(int i = 0; i < 10; i++)
        {
            int option = int.Parse(Console.ReadLine());
            if(option == correct[i]){
                score++;
                Console.WriteLine("option number "+option+" for Question number "+(i+1)+" is correct");
            }
            else Console.WriteLine("option number "+option+" for Question number "+(i+1)+" is Incorrect");
        }

        Console.WriteLine("Total Score : "+score);
        double percentage = score * 10;

        Console.WriteLine("Percentage is "+percentage+" %");



        
    }
}