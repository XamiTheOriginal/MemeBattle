using System;
using System.IO;

namespace MemeBattle.Game;

public static class MemeManager
{
    public static void PrintMeme(string filepath) 
    {
        string filePath = Path.Combine(AppContext.BaseDirectory, filepath);
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
        Console.WriteLine('\n');
    }

    /// <summary>
    /// Print l'intérieur d'un fichier meme aléatoire
    /// range is the number of meme there is in /Memes 
    /// </summary>
    /// <param name="range"></param>
    public static void PrintMemeRandom(int range)
    {
        Random random = new Random();
        int memeNumber = random.Next(1, range+1);
        string filepath = Path.Combine(AppContext.BaseDirectory, "Memes", $"Meme{memeNumber}.txt");
        try
        {
            string content = File.ReadAllText(filepath);
            Console.WriteLine(content);
        }
        catch (Exception e)
        {
            Console.WriteLine("Il a pas trouvé le fichier");
            Console.WriteLine(e);
            throw;
        }
    }

    public static void PlaySong() //Not sure to implement it for now
    {
        throw new NotImplementedException();
    }
}