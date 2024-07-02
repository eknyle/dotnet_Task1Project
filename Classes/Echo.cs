using System;

namespace Task1Project.Classes
{
    public class Echo: IMove
    {
        public string? Message(string? value)
        {
            Console.WriteLine($"{value}");
            return string.Empty;
        }

    }
}
