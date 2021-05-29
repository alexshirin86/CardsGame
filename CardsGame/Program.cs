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

            bool logining;
            string name;
            do
            {
                name = Console.ReadLine();
                switch (name)
                {
                    case "exit":
                        logining = true;
                        break;
                    case "new":
                        logining = game.Login(name, "pass");
                        Console.WriteLine("Введите новое имя.");
                        name = Console.ReadLine();
                        logining = game.NewAccount(name, "pass");
                        break;
                    default:
                        logining = game.Login(name, "pass");
                        if (!logining)
                        {
                            Console.WriteLine("Попробуйте еще раз или введите exit для выхода.");
                        }
                        break;
                }               
                
            } while (!logining);

            if (name == "exit")
            {
                Console.WriteLine("Досвидания!");
            }
            Console.Read();
        }
    }
}
