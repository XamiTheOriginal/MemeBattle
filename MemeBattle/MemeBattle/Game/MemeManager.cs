using System;

namespace MemeBattle.Game;

public class MemeManager
{
    public void PrintMeme(string filepath) 
    {
        string filePath = $"~/{filepath}";
        string contenu = File.ReadAllText(filePath);
        Console.WriteLine(contenu);
        Console.WriteLine('\n');
    }

    public void PlaySong()
    {
        throw new NotImplementedException();
    }
}