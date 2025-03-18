// See https://aka.ms/new-console-template for more information
using MemeBattle.Game;
internal class Program
{
    public static void Main(string[] args)
    {
        List<string> choice = new List<string>(4);
        choice.Add("Choice 1");
        choice.Add("Choice 2");
        choice.Add("Choice 3");
        choice.Add("Choice 4");
        Question question = new Question("Question 1", choice, 3);
        Console.Write(question.ToString());
    }
}