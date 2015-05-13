using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        Console.WriteLine("Please enter your contacts - one name and a phone number, separated by a score");
        string input = Console.ReadLine().Trim();

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (!((input = Console.ReadLine()) == "search"))
        {
            string[] items = input.Split('-');

            if (phonebook.ContainsKey(items[0]))
                phonebook.Remove(items[0]);
            phonebook.Add(items[0], items[1]);

            Console.WriteLine("Search: ");
            input = Console.ReadLine().Trim();
        }

        input = Console.ReadLine().Trim();
        while (input.Length > 0)
        {
            if (phonebook.ContainsKey(input))
                Console.WriteLine("{0} -> {1}", input, phonebook[input]);
            else
                Console.WriteLine("Contact {0} does not exist.", input);

            input = Console.ReadLine().Trim();
        }
    }
}