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
}