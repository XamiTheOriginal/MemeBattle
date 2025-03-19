
namespace MemeBattle.Game;

public class MemeManager
{
    public void PrintMeme(string filepath) 
    {
        string filePath = $"~/{filepath}";
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
        Console.WriteLine('\n');
    }

    public void PlaySong()
    {
        throw new NotImplementedException();
    }
}