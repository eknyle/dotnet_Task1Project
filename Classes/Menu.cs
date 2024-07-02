using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1Project.Classes
{
    public class Menu
    {
              
        private static List<string> Commands = ["/ start", "/ help", "/ info", "/ exit", "/ echo"];

        public static string GetAllowedCommands(string name) {  

            return String.Join(", ", name.Length>0?Commands: Commands.GetRange(0,Commands.Count-1)); 
        }
        public static IMove? Move(string command)
        {
            switch (command.Replace(" ",""))
            {
                case "/start":
                    return new Start();
                case "/help":
                    return new Help();
                case "/info":
                    return new Info();
                case "/exit":
                    return null;
                case "/echo":
                    return new Echo();
                default:
                    throw new ArgumentException("Введена неверная команда");
            }
        }
    }
}
