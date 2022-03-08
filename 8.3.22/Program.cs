
namespace Programmierentwicklung;

public class program
{
    public static void Main(string[] args)
    {
        string[] source = getlorem().Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        AusgabeWoerter(source);
        LaengstesWort(source);
        KleinstesWort(source);
        Durchschnitt(source);
        Saetze(source);
    }
    public static string getlorem()
    {
        return File.ReadAllText(@"C:\Users\walte\OneDrive\Desktop\Lorem Ipsum.txt");
    }

    public static void AusgabeWoerter(string[] source)
    {
        Console.WriteLine($"Anzahl Wörter: {source.Length}");
    }

    public static void LaengstesWort(string[] source)
    {
        string longest = source.OrderByDescending(s => s.Length).First();
        Console.WriteLine($"Das längste Wort ist {longest}, mit {longest.Length} Zeichen.");
    }

    public static void KleinstesWort(string[] source)
    {
        string smallest = source.OrderByDescending(s => s.Length).Last();
        Console.WriteLine($"Das kleinste Wort ist {smallest}, mit {smallest.Length} Zeichen.");
    }

    public static void Durchschnitt(string[] source)
    {
        int Zeichen = 0;
        for (int i = 0; i < source.Length; i++)
        {
            Zeichen = Zeichen + source[i].Length;
        }
        double durch = Zeichen / source.Length;
        Console.WriteLine($"Der Durchschnitt beträgt {durch} Zeichen.");
    }

    public static void Saetze(string[] source)
    {
        int count = getlorem().Count(f => f == '.');
        Console.WriteLine($"Der Text beinhaltet {count} Sätze");
    }
}