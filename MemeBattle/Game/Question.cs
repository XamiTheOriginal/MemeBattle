using Newtonsoft.Json;

namespace MemeBattle.Game;

public class Question
{
    [JsonProperty("question")]
    public string QuestionText { get; set; }
    [JsonProperty("answers")]
    public List<string> Answers { get; set; }
    [JsonProperty("correctAnswerIndex")]
    public int CorrectAnswerIndex { get; set; }
    
    public Question(string questionText, List<string> answers, int correctAnswerIndex) //Mostly for tests
    {
        this.QuestionText = questionText;
        this.Answers = answers;
        this.CorrectAnswerIndex = correctAnswerIndex;
    }
    
    public bool IsCorrect(int answer) => answer == CorrectAnswerIndex;
    
    public override string ToString() //For debugging purpose only or to play the game (uncomment the last comment for
                                      //debugging purpose
    {
        string res = "";
        int l = this.Answers.Count;
        res += $"The question is {this.QuestionText}" + '\n' + "The choices are :" + '\n';
        for (int i = 0; i < l; ++i)
        {
            res += $"{this.Answers[i]}" + '\n';
        }
        //res += $"The correct answer is {this.CorrectAnswerIndex}";
        return res;
    }
}