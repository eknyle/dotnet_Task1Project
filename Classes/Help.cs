using System;

namespace Task1Project.Classes
{
    public class Help: IMove
    {
        public string? Message(string? value)
        {
            Console.WriteLine($"{value} Справка: Программа выдает список доступных команд. При вводе команды пользователь получает запрошенную информацию. Чтобы выйти из программы достаточно ввести команду / exit.");
            return string.Empty;
        }

    }
}
