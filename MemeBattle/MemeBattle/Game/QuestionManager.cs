using Newtonsoft.Json;

namespace MemeBattle.Game;
public class QuestionManager
{
    private readonly string _filePath;

    public QuestionManager(string filepath)
    {
        this._filePath = filepath;
    }

    public List<Question> LoadQuestions()
    {
        if (!File.Exists(this._filePath))
        {
            Console.WriteLine("The file doesn't exist");
            return new List<Question>();
        }

        string json = File.ReadAllText(this._filePath);
        if (string.IsNullOrWhiteSpace(json))
        {
            Console.WriteLine("The file is empty.");
            return new List<Question>();
        }

        try
        {
            var data = JsonConvert.DeserializeObject<QuizData>(json);
            return data?.Quiz ?? new List<Question>();
        }
        catch (JsonException e)
        {
            Console.WriteLine($"Error loading JSON: {e.Message}");
            return new List<Question>();
        }
    }
}