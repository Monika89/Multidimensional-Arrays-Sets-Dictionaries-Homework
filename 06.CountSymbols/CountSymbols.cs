using System;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        Console.WriteLine("Please enter your text: ");
        char[] letters = Console.ReadLine().ToCharArray();
        Array.Sort(letters);
        var text = letters.GroupBy(x => x);
        foreach (var letter in text)
        {
            Console.WriteLine("{0}: {1} time/s", letter.Key, letter.Count());
        }
    }
}