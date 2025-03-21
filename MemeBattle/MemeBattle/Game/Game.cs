namespace MemeBattle.Game;

public class Game
{
    public void Play() //J'ai pété
    {
        throw new NotImplementedException();
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