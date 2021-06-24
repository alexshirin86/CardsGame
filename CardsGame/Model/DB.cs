
using System;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data.Linq;
using System.Data;
using System.Collections.Generic;

namespace Model {
	public class DB {
        public static string ConnectionString = $@"Data Source=.\SQLEXPRESS;Initial Catalog={GDatabase};Integrated Security=True";
        public const string GDatabase = "GDatabase";
        public static string DirectoryApp = Directory.GetCurrentDirectory();
        public static string GDatabaseFile = $"{DirectoryApp}\\GDatabaseDB.mdf";
        public static void CreateDatabase()
        {            
            String str;
            SqlConnection myConn = new SqlConnection("Server = localhost\\SQLEXPRESS; Trusted_Connection=True; database = master");

            str = $"CREATE DATABASE {GDatabase} ON PRIMARY " +
             "(NAME = GDatabase_Data, " +
             $"FILENAME = '{GDatabaseFile}', " +
             "SIZE = 10MB, MAXSIZE = 20MB, FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("БД создана.");

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public async static void OpenDatabaseAsync()
        {
            DataContext db = new DataContext(ConnectionString);
            db.
            //string strConect = "Data Source = localhost\\SQLEXPRESS;" +
            //"AttachDbFilename = C:\Northwind.mdf;";
            //SqlConnection connection = new SqlConnection($"Server = .\\SQLEXPRESS; AttachDbFilename = {DirectoryApp}\\GDatabaseDB.mdf; Trusted_Connection = true");


            try
            {
                //await connection.OpenAsync();
                
                Console.WriteLine("Подключение открыто.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //if (connection.State == ConnectionState.Open)
               // {
               //     connection.Close();
               //     Console.WriteLine("Подключение закрыто.");
               // }
                
            }
        }


        public async static void CreateTableAsync( SqlConnection connection, string table)
        {

            try
            {
                //SqlCommand myCommand = new SqlCommand(str, connection);
                await connection.OpenAsync();
                Console.WriteLine("Подключение открыто.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Подключение закрыто.");
                }

            }
        }


        private static Dictionary <string, EnumTypeAccount> _dUsers = new Dictionary<string, EnumTypeAccount> 
		{ 
		    ["admin"] = EnumTypeAccount.Admin, 
		    ["player"] =  EnumTypeAccount.Player, 
		    ["vip"] =  EnumTypeAccount.Vip, 
		    ["new"] = EnumTypeAccount.Player
		};
        private static int _crystalPrice = 100;
        private static Dictionary <string, EnumTypeAccount> _dItems = new Dictionary<string, EnumTypeAccount> 
		{ 
		    ["admin"] = EnumTypeAccount.Admin, 
		    ["player"] = EnumTypeAccount.Player, 
		    ["vip"] = EnumTypeAccount.Vip, 
		    ["new"] = EnumTypeAccount.Player
		};
        private static int _goldPrice = 50;
        private static List <ProductDB> _productMarketPlayer = new List<ProductDB>();
		private static Dictionary <int, CardDB> _dCards = new Dictionary<int, CardDB> ();
		private static List <ProductDB> _productMarketVip = new List<ProductDB>();
        private static int _money = 0;
        private static int _disscount = 0;

        static DB(){
                       

            ProductDB product1 = new ProductDB("Продукт1", 0, 5, 50);
			ProductDB product2 = new ProductDB("Продукт2", 0, 15, 500);
			ProductDB product3 = new ProductDB("Продукт2", 0, 3, 100);
			ProductDB product4 = new ProductDB("Продукт2", 0, 24, 150);
	
			_productMarketPlayer.Add(product1);
			_productMarketPlayer.Add(product2);
			_productMarketVip.Add(product3);
			_productMarketVip.Add(product4);
		}

		
        public static bool HasUser(string name, string pass)
        {
            return _dUsers.ContainsKey(name);
        }

      
        public static int GetId(string name)
        {

            return 0;
        }

       
        public static EnumTypeAccount GetTypeAccount(string name)
        {

            return _dUsers[name];
        }

       
        public static bool NewAccount(string name)
        {

            _dUsers.Add(name, EnumTypeAccount.Player);
            return _dUsers.ContainsKey(name);
        }

       
        public static CardDB GetCard(int id)
        {

            return _dCards[id];
        }

        public static List<ProductDB> GetProductsMarketPlayer(){

			return _productMarketPlayer;
		}

        public static int GoldPrice {
            get {
                return _crystalPrice;
            }
            set {
                _crystalPrice = value;
            }
        }

        public static List<ProductDB> GetProductsMarketVip(){

			return _productMarketVip;
		}

        public static int CrystalPrice {
            get {
                return _goldPrice;
            }
            set {
                _goldPrice = value;
            }
        }


        public static int GetMoney(int id)
        {

            return _money;
        }

       
        public static int GetDisscount(int id)
        {

            return _disscount;
        }

       
        public static void SetMoney(int id, int money)
        {

            _money += money;
        }

    }

}