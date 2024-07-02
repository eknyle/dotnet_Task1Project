using System;

namespace Task1Project.Classes
{
    public class Start: IMove
    {
        public string? Message(string? value)
        {
            Console.WriteLine($"Введите ваше имя:");
            return Console.ReadLine();
        }

    }
}
