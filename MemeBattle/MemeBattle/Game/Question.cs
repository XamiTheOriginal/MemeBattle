namespace MemeBattle.Game;

public class Question
{
    public string Text { get; set; }
    public List<string> Choices { get; set; }
    public int CorrectAnswer { get; set; }
    
    public Question(string text, List<string> choices, int correctAnswer) //Mostly for tests
    {
        this.Text = text;
        this.Choices = choices;
        this.CorrectAnswer = correctAnswer;
    }
    
    public Question() { }

    public bool IsCorrect(int answer) => answer == CorrectAnswer;
    
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