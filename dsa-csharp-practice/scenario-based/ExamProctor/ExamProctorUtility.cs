using System;
using System.Collections.Generic;

public class ExamProctorUtility : IExamProctor
{
    private Stack<int> navigationStack;
    private Dictionary<int, string> answerMap;
    private Dictionary<int, string> correctAnswers;

    public ExamProctorUtility()
    {
        navigationStack = new Stack<int>();
        answerMap = new Dictionary<int, string>();

        // Predefined correct answers (can come from DB)
        correctAnswers = new Dictionary<int, string>()
        {
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"}
        };
    }

    // Track question navigation
    public void VisitQuestion(int questionId)
    {
        navigationStack.Push(questionId);
        Console.WriteLine("Visited Question: " + questionId);
    }

    // Store answer
    public void SubmitAnswer(int questionId, string answer)
    {
        answerMap[questionId] = answer;
        Console.WriteLine("Answer saved for Question " + questionId);
    }

    // Display navigation history
    public void ShowNavigationHistory()
    {
        if (navigationStack.Count == 0)
        {
            Console.WriteLine("No navigation history.");
            return;
        }

        Console.WriteLine("Question Navigation (Last Visited First):");
        foreach (int q in navigationStack)
        {
            Console.WriteLine("Question " + q);
        }
    }

    // Scoring logic function
    public int EvaluateScore()
    {
        int score = 0;

        foreach (var entry in correctAnswers)
        {
            int questionId = entry.Key;
            string correctAnswer = entry.Value;

            if (answerMap.ContainsKey(questionId) &&
                answerMap[questionId].Equals(correctAnswer))
            {
                score++;
            }
        }

        return score;
    }
}
