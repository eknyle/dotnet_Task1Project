using System;

namespace Task1Project.Classes
{
    public class Info: IMove
    {
        public string? Message(string? value)
        {
            Console.WriteLine($"{value}  Версия 1.0 Дата создания 02.07.2024");
            return string.Empty;
        }

    }
}
