namespace Task_1
{
    public class Question
    {
        public string QuestionText { get; }

        public string[] Answers { get; }

        public int CorrectAnswer { get; }

        public double Score { get; }

        public Question(string question, string[] answers, int correctAnswer, double score)
        {
            QuestionText = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
            Score = score;
        }
    }
}