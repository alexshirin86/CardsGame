///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      30-май-2021 4:02:00
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class DB {

		private static Dictionary <string, Type> DictionaryUsers = new Dictionary<string, Type> 
		{ 
		    ["admin"] = typeof(Admin), 
		    ["player"] = typeof(Player), 
		    ["vip"] = typeof(Vip), 
		    ["new"] = typeof(Player)
		};
		private static int crystalPrice = 100;
		private static Dictionary <string, Type> DictionaryItems = new Dictionary<string, Type> 
		{ 
		    ["admin"] = typeof(Admin), 
		    ["player"] = typeof(Player), 
		    ["vip"] = typeof(Vip), 
		    ["new"] = typeof(Player)
		};

		public DB(){

		}

		~DB(){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public static bool HasUser(string name, string pass){

			return DictionaryUsers.ContainsKey(name);
		}

		public static int CrystalPrice{
			get {
				return crystalPrice;
			}
			set {
				crystalPrice = value;
			}
		}

		/// 
		/// <param name="name"></param>
		public static int GetId(string name){

			return 0;
		}

		/// 
		/// <param name="name"></param>
		public static Type GetTypeAccount(string name){

			return DictionaryUsers[name];
		}

		/// 
		/// <param name="name"></param>
		public static bool NewAccount(string name){

			DictionaryUsers.Add(name, typeof(Player));
			return DictionaryUsers.ContainsKey(name);
		}

		/// 
		/// <param name="id"></param>
		public static CardDB GetCard(int id){

			CardDB card = new CardDB( "карта", "карта", 100, 0, 0 );
	
			Dictionary<int, CardDB> dict = new Dictionary<int, CardDB>{ 
			    [1] = card
			};
		
			return dict[ id ];
		}

	}//end DB

}//end namespace Model