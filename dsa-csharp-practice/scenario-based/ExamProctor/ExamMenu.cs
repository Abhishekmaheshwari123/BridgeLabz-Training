using System;

public class ExamMenu
{
    private IExamProctor exam = new ExamProctorUtility();

    public void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Exam Proctor Menu ---");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Submit Answer");
            Console.WriteLine("3. Show Navigation History");
            Console.WriteLine("4. Submit Exam");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Question ID: ");
                    exam.VisitQuestion(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Enter Question ID: ");
                    int qid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Answer: ");
                    string ans = Console.ReadLine();
                    exam.SubmitAnswer(qid, ans);
                    break;

                case 3:
                    exam.ShowNavigationHistory();
                    break;

                case 4:
                    int score = exam.EvaluateScore();
                    Console.WriteLine("Final Score: " + score);
                    break;

                case 5:
                    Console.WriteLine("Exiting Exam Proctor...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
