using MemeBattle.Game;

namespace MemeBattle;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        string memesPath = Path.Combine(AppContext.BaseDirectory, "Memes");
        int memeCount = Directory.Exists(memesPath)
            ? Directory.GetFiles(memesPath, "*.txt").Length
            : 0;

        Console.WriteLine("Are you here to debug ? (1 = yes / 0 = no)");
        bool debugMode = int.TryParse(Console.ReadLine(), out int debug) && debug == 1;

        if (debugMode)
        {
            string filepath = @"C:\Users\maxim\OneDrive\Bureau\C#\MemeBattle\MemeBattle\MemeBattle\Game\Questions.json";

            QuestionManager qManager = new QuestionManager(filepath);
            List<Question> questions = qManager.LoadQuestions();

            if (questions.Count > 0)
            {
                Console.WriteLine("Questions were loaded successfully\n");
                foreach (var q in questions)
                {
                    Console.WriteLine(q.ToString());
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No questions were found");
            }
        }
        else
        {
            
            string filePath = Path.Combine(AppContext.BaseDirectory, "Game", "Questions.json");
            var manager = new QuestionManager(filePath);
            List<Question> questList = manager.LoadQuestions();

            if (questList.Count == 0)
            {
                Console.WriteLine("No questions found in the file.");
                return;
            }

            Console.Write($"How many questions do you want to play? (max {questList.Count}) : ");
            if (!int.TryParse(Console.ReadLine(), out int requestedCount) || requestedCount <= 0)
            {
                Console.WriteLine("Invalid number of questions. Exiting.");
                return;
            }

            int numQuestions = Math.Min(requestedCount, questList.Count);
            Game.Game game = new Game.Game(numQuestions);

            // Mélanger les questions et en prendre les N premières
            Random rng = new Random();
            var selectedQuestions = questList.OrderBy(_ => rng.Next()).Take(numQuestions).ToList();

            int score = 0;

            foreach (var question in selectedQuestions)
            {
                game.AskQuestion(question);

                if (game.CheckAnswer(question))
                {
                    Console.WriteLine("GG BRO\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer!");
                    Console.WriteLine($"The correct answer was: {question.Answers[question.CorrectAnswerIndex]}\n");
                    
                    MemeManager.PrintMemeRandom(memeCount);
                }

                Console.WriteLine("---------------------------------------------------------------------------\n");
            }

            Console.WriteLine($"Your final score is {score}/{game.NumberTurn} !");
        }
    }
}
