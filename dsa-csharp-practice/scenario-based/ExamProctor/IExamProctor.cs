public interface IExamProctor
{
    void VisitQuestion(int questionId);
    void SubmitAnswer(int questionId, string answer);
    void ShowNavigationHistory();
    int EvaluateScore();
}
