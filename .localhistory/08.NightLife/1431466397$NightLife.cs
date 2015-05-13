using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> program =
            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
 
        String inputLine = Console.ReadLine().Trim();
 
        while (!inputLine.Equals("END"))
        {
            string[] items = inputLine.Split(';');
            string city = items[0];
            string venue = items[1];
            string performer = items[2];
 
            if (!program.ContainsKey(city))
            {
                SortedDictionary<string, SortedSet<string>> cityProgram =
                    new SortedDictionary<string, SortedSet<string>>();
                program[city] = cityProgram;
            }
 
            if (!program[city].ContainsKey(venue))
            {
                SortedSet<string> cityVenueProgram = new SortedSet<string>();
                program[city][venue] = cityVenueProgram;
            }
 
            program[city][venue].Add(performer);
 
            inputLine = Console.ReadLine().Trim();
        }
 
        foreach (string city in program.Keys)
        {
            Console.WriteLine(city);
            SortedDictionary<string, SortedSet<string>> cityVenues = program[city];
            foreach (string venue in cityVenues.Keys)
            {
                SortedSet<string> performers = cityVenues[venue];
                string performersStr = string.Join(", ", performers);
                Console.WriteLine("->{0}: {1}", venue, performersStr);
            }
        }
    }
}