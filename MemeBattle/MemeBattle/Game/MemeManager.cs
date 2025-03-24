namespace MemeBattle.Game;

public static class MemeManager
{
    public static void PrintMeme(string filepath) 
    {
        string filePath = $"~/{filepath}";
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
        Console.WriteLine('\n');
    }

    public static void PlaySong() //Not sure to implement it for now
    {
        throw new NotImplementedException();
    }
}