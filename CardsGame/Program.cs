using System;
using Model;


namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Добро пожаловать");

            Console.WriteLine("Ведите одно из имен ниже.");
            Console.WriteLine("admin, player, vip, new или exit для выхода.");

            bool exit = false;
            bool logining;
            string command;
            do
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "exit":
                        exit = true;
                        break;
                    case "new":
                        logining = game.Login(command, "pass");
                        Console.WriteLine("Введите новое имя.");
                        command = Console.ReadLine();
                        logining = game.NewAccount(command, "pass");
                        break;
                    default:
                        logining = game.Login(command, "pass");
                        if (!logining)
                        {
                            Console.WriteLine("Попробуйте еще раз или введите exit для выхода.");
                        }
                        break;
                }

                exit = game.Exit;
            } while (!exit);

            Console.WriteLine("Досвидания!");

            Console.ReadKey();
        }
    }
}
