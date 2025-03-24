namespace MemeBattle.Game;

public class Game
{
    public int NumberTurn = 0;
    
    public Game(int numberTurn)
    {
        this.NumberTurn = numberTurn;
    }
    public void AskQuestion(Question question)
    {
        Console.WriteLine(question.QuestionText);
        for (int i = 0; i < question.Answers.Count; ++i)
        {
            Console.WriteLine(question.Answers[i]);
        }
    }

    public bool CheckAnswer(Question question)
    {
        Console.WriteLine("Enter the index of your response :");
        int rep = Console.Read();
        if (question.CorrectAnswerIndex + 1 == rep)
            return true;
        return false;
    }
}