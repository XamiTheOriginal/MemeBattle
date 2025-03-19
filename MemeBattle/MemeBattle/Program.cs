// See https://aka.ms/new-console-template for more information
using MemeBattle.Game;
internal class Program
{
    public static void Main(string[] args)
    {
        bool debugMod = true;
        Console.WriteLine("Are you here to debug ?(1/0)");
        int debug = Console.Read();
        if (debug > 0) //Debug part
        {
            string filepath = @"C:\Users\maxim\OneDrive\Bureau\C#\MemeBattle\MemeBattle\MemeBattle\Game\Questions.json";

            QuestionManager qManager = new QuestionManager(filepath);
            List<Question> questions = qManager.LoadQuestions();
            if (questions.Count > 0)
            {
                Console.WriteLine("Questions were loaded successfully");
                foreach (var q in questions)
                {
                    Console.WriteLine(q.ToString());
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No question were found");
            }
        }
        else //Game part
        {
            
        }
    }
}