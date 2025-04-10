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
        Console.WriteLine();
        Console.WriteLine($"QuestionText : {question.QuestionText}");
        for (int i = 0; i < question.Answers.Count; ++i)
        {
            Console.WriteLine(question.Answers[i]);
        }
    }

    public bool CheckAnswer(Question question) //TODO : Fix me
    {
        Console.WriteLine("Enter the index of your response :");
        string? reponse = Console.ReadLine();
        if (reponse.Length > 2)
        {
            Console.WriteLine("Enter only one digit between 0 and 3");
            return CheckAnswer(question);
        }
        int rep = reponse[0] - '0';
        if (rep < 0 || rep >= question.Answers.Count)
        {
            Console.WriteLine("Out of bounds, choose a valid index.");
            return CheckAnswer(question);
        }
        return question.CorrectAnswerIndex == rep;
    }
}