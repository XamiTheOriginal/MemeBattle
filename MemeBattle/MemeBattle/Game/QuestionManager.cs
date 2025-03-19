using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MemeBattle.Game;
public class QuestionManager
{
        public readonly string filePath;

    public QuestionManager(string filepath)
    {
        this.filePath = filepath;
    }

    public List<Question> LoadQuestions()
    {
        if (!File.Exists(this.filePath))
        {
            Console.WriteLine("The file doesn't exist");
            return new List<Question>();
        }

        string json = File.ReadAllText(this.filePath);
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