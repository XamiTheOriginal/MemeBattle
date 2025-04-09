using MemeBattle.Game;

namespace MemeBattle;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        string memesPath = Path.Combine(AppContext.BaseDirectory, "Memes");
        int range = Directory.Exists(memesPath) 
            ? Directory.GetFiles(memesPath, "*.txt").Length 
            : 0;
        
        Random random = new Random();
        Console.WriteLine("Are you here to debug ?(1/0)");
        bool debugMode = int.TryParse(Console.ReadLine(), out int debug) && debug == 1;
        if (debugMode) //Debug part
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
            int temp = random.Next(0, 11);
            Game.Game game = new Game.Game(temp);

            string filePath = Path.Combine(AppContext.BaseDirectory, "Game", "Questions.json");
            var manager = new QuestionManager(filePath);
            List<Question> questList = manager.LoadQuestions();
            
            for (int i = 0; i < game.NumberTurn; ++i)
            {
                Question currQuestion = questList[i];
                game.AskQuestion(currQuestion); //TODO : correct me
                if(game.CheckAnswer(currQuestion))
                {
                    Console.WriteLine("GG BRO");
                }
                else
                {
                    MemeManager.PrintMemeRandom(range);
                    Console.WriteLine($"The correct answer was : {currQuestion.CorrectAnswerIndex.ToString()}");
                    //TODO : override the ToString for CorrectAnswerIndex
                }
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }
    }
}