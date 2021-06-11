///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      31-май-2021 18:13:12
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;





using Model;
namespace Model {
	public class DB {

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
			
			CardDB card1 = new CardDB("карта1", "карта1", 100, 0 );
			CardDB card2 = new CardDB("карта2", "карта2", 50, 0);
			CardDB card3 = new CardDB("карта3", "карта3", 200, 0);
			CardDB card4 = new CardDB("карта4", "карта4", 0, 5);
			CardDB card5 = new CardDB("карта5", "карта5", 0, 15);
			CardDB card6 = new CardDB("карта6", "карта6", 0, 3);
			CardDB card7 = new CardDB("карта7", "карта7", 0, 24);

			SerializeWriteJson(1, card1);
			SerializeWriteJson(2, card2);
			SerializeWriteJson(3, card3);
			SerializeWriteJson(4, card4);
			SerializeWriteJson(5, card5);
			SerializeWriteJson(6, card6);
			SerializeWriteJson(7, card7);

			_dCards.Add(1, DeserializeWriteJson(1).Result);
			_dCards.Add(2, DeserializeWriteJson(2).Result);
			_dCards.Add(3, DeserializeWriteJson(3).Result);
			_dCards.Add(4, DeserializeWriteJson(4).Result);
			_dCards.Add(5, DeserializeWriteJson(5).Result);
			_dCards.Add(6, DeserializeWriteJson(6).Result);
			_dCards.Add(7, DeserializeWriteJson(7).Result);

			Console.WriteLine(_dCards.ToString());
	
			ProductDB product1 = new ProductDB("Продукт1", 0, 5, 50);
			ProductDB product2 = new ProductDB("Продукт2", 0, 15, 500);
			ProductDB product3 = new ProductDB("Продукт2", 0, 3, 100);
			ProductDB product4 = new ProductDB("Продукт2", 0, 24, 150);
	
			_productMarketPlayer.Add(product1);
			_productMarketPlayer.Add(product2);
			_productMarketVip.Add(product3);
			_productMarketVip.Add(product4);
		}

		async static void SerializeWriteJson(int id, CardDB card)
        {
			using (FileStream fs = new FileStream($"card{id}.json", FileMode.OpenOrCreate))
			{
				await JsonSerializer.SerializeAsync<CardDB>(fs, card);				
			}
		}

		async static Task<CardDB> DeserializeWriteJson(int id)
        {
			CardDB card;
			using (FileStream fs = new FileStream($"user{id}.json", FileMode.OpenOrCreate))
			{
				card = await JsonSerializer.DeserializeAsync<CardDB>(fs);				
			}
			return card;
		}

        /// <summary>
        ///   <param name="name"></param>
        ///   <param name="pass"></param>
        /// </summary>
        public static bool HasUser(string name, string pass)
        {

            return _dUsers.ContainsKey(name);
        }

        /// <summary>
        ///   <param name="name"></param>
        /// </summary>
        public static int GetId(string name)
        {

            return 0;
        }

        /// <summary>
        ///   <param name="name"></param>
        /// </summary>
        public static EnumTypeAccount GetTypeAccount(string name)
        {

            return _dUsers[name];
        }

        /// <summary>
        ///   <param name="name"></param>
        /// </summary>
        public static bool NewAccount(string name)
        {

            _dUsers.Add(name, EnumTypeAccount.Player);
            return _dUsers.ContainsKey(name);
        }

        /// <summary>
        ///   <param name="id"></param>
        /// </summary>
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

        /// <summary>
        ///   <param name="id"></param>
        /// </summary>
        public static int GetMoney(int id)
        {

            return _money;
        }

        /// <summary>
        ///   <param name="id"></param>
        /// </summary>
        public static int GetDisscount(int id)
        {

            return _disscount;
        }

        /// <summary>
        ///   <param name="id"></param>
        ///   <param name="money"></param>
        /// </summary>
        public static void SetMoney(int id, int money)
        {

            _money += money;
        }

    }//end DB

}//end namespace Model