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

    public bool CheckAnswer(Question question)
    {
        Console.WriteLine("Enter the index of your response:");
        string? reponse = Console.ReadLine();

        // Vérifie que la réponse contient exactement 1 caractère numérique
        if (string.IsNullOrEmpty(reponse) || reponse.Length != 1 || !char.IsDigit(reponse[0]))
        {
            Console.WriteLine("Enter only one digit between 0 and 3");
            return CheckAnswer(question); // récursif mais sécurisé
        }

        int rep = reponse[0] - '0';

        if (rep < 0 || rep >= question.Answers.Count)
        {
            Console.WriteLine("Out of bounds, choose a valid index.");
            return CheckAnswer(question);
        }

        return question.CorrectAnswerIndex+1 == rep;
    }

}