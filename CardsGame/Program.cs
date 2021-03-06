using System;
using System.IO;
using Model;
using Model.Item;


namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (File.Exists(DB.GDatabaseFile))
            {
                DB.DropDatabase();
                Console.WriteLine("БД существует. Удаление.");
            }
            DB.CreateDatabase();
            DB.OpenDatabase();

            //LargeShip l2 = DB.DataDB.GetTable<LargeShip>();

            LargeShip l1 = new LargeShip(1,2,3,4, "LargeShip 1", "LargeShip.jpg","LargeShip");



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
