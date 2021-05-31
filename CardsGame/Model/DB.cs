///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      31-май-2021 11:35:58
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class DB {

		private static Dictionary <string, Type> _dUsers = new Dictionary<string, Type> 
		{ 
		    ["admin"] = typeof(Admin), 
		    ["player"] = typeof(Player), 
		    ["vip"] = typeof(Vip), 
		    ["new"] = typeof(Player)
		};
		private static int _crystalPrice = 100;
		private static Dictionary <string, Type> _dItems = new Dictionary<string, Type> 
		{ 
		    ["admin"] = typeof(Admin), 
		    ["player"] = typeof(Player), 
		    ["vip"] = typeof(Vip), 
		    ["new"] = typeof(Player)
		};
		private static int _goldPrice = 50;
		private static List <CardDB> _cardMarketPlayer = new List<CardDB>();
		private static Dictionary <int, CardDB> _dCards = new Dictionary<int, CardDB> ();
		private static List <CardDB> _cardMarketVip = new List<CardDB>();

		static DB(){

			CardDB card1 = new CardDB("карта1", "карта1", 100, 0, 0 );
			CardDB card2 = new CardDB("карта2", "карта2", 50, 0, 0);
			CardDB card3 = new CardDB("карта3", "карта3", 200, 0, 0);
			CardDB card4 = new CardDB("карта4", "карта4", 0, 5, 50);
			CardDB card5 = new CardDB("карта5", "карта5", 0, 15, 500);
			CardDB card6 = new CardDB("карта6", "карта6", 0, 3, 100);
			CardDB card7 = new CardDB("карта7", "карта7", 0, 24, 150);
	
			_dCards.Add(1, card1);
			_dCards.Add(2, card2);
			_dCards.Add(3, card3);
			_dCards.Add(4, card4);
			_dCards.Add(5, card5);
			_dCards.Add(6, card6);
			_dCards.Add(7, card7);
			_cardMarketPlayer.Add(card4);
			_cardMarketPlayer.Add(card5);
			_cardMarketVip.Add(card6);
			_cardMarketVip.Add(card7);
		}

		/// 
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public static bool HasUser(string name, string pass){

			return _dUsers.ContainsKey(name);
		}

		/// 
		/// <param name="name"></param>
		public static int GetId(string name){

			return 0;
		}

		/// 
		/// <param name="name"></param>
		public static Type GetTypeAccount(string name){

			return _dUsers[name];
		}

		/// 
		/// <param name="name"></param>
		public static bool NewAccount(string name){

			_dUsers.Add(name, typeof(Player));
			return _dUsers.ContainsKey(name);
		}

		/// 
		/// <param name="id"></param>
		public static CardDB GetCard(int id){

			return _dCards[ id ];
		}

		public static List<CardDB> GetCardsMarketPlayer(){

			return _cardMarketPlayer;
		}

		public static int GoldPrice{
			get {
				return _crystalPrice;
			}
			set {
				_crystalPrice = value;
			}
		}

		public static List<CardDB> GetCardsMarketVip(){

			return _cardMarketVip;
		}

		public static int CrystalPrice{
			get {
				return _goldPrice;
			}
			set {
				_goldPrice = value;
			}
		}

	}//end DB

}//end namespace Model