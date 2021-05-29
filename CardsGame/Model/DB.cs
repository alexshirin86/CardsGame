///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      29-май-2021 21:25:01
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



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

	}//end DB

}//end namespace Model