using System;

namespace Task1Project.Classes
{
    public class Game
    {
        public void Begin()
        {
            string value = string.Empty;
            while (true)
            {
                Console.WriteLine($"{value} Выберите действие из списка команд ({ Menu.GetAllowedCommands(value) }):");
                string playerMove = Console.ReadLine();

                IMove move = Menu.Move(playerMove);

                if (move == null) break;
                
                string result= move.Message(value);
               
                if (result != null&& result != string.Empty) value = result;
            }
        }
    }
}
