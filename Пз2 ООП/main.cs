using System;
using System.Text.RegularExpressions;

class Parser
{
    private Regex regex = new Regex(@"([0-9]{1,6})\*([0-9])([<>=]=?)([0-9]{1,6})");

    public void Parse()
    {
        Console.WriteLine("Enter the expression:");
        string input = Console.ReadLine();

        Match matches = regex.Match(input);

        if (matches.Success)
        {



            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parser parser = new Parser();
        parser.Parse();
    }
}