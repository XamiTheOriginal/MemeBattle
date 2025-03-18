namespace MemeBattle.Game;

public class Question
{
    public string Text { get; set; }
    public List<string> Choices { get; set; }
    public int CorrectAnswer { get; set; }
    
    public Question(string text, List<string> choices, int correctAnswer)
    {
        this.Text = text;
        this.Choices = choices;
        this.CorrectAnswer = correctAnswer;
    }
    
    public bool IsCorrect(int answer) => answer == CorrectAnswer;

    //Those are to create the Question object
    private string initQuestion(string filePath)
    {
        return "";
    }

    private List<string> initChoice(string filePath)
    {
        throw new NotImplementedException();
    }

    private int initCorrectAwnser(string filePath)
    {
        return -1;
    }
    
    public override string ToString() //For debugging purpose only
    {
        string res = "";
        int l = this.Choices.Count;
        res += $"The question is {this.Text}" + '\n' + "The choices are :" + '\n';
        for (int i = 0; i < l; ++i)
        {
            res += $"{this.Choices[i]}" + '\n';
        }
        res += $"The correct anwser is {this.CorrectAnswer}";
        return res;
    }
}