///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      29-май-2021 19:33:00
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public class DB {

		private static List <string> ListUsers = new List<string>{"admin", "player", "vip", "new"};
		private static int crystalPrice = 100;

		
		/// 
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public static bool HasUser(string name, string pass){

			return ListUsers.Contains(name);
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

			return typeof(Player);
		}

		/// 
		/// <param name="name"></param>
		public static bool NewAccount(string name){

			ListUsers.Add(name);
			return ListUsers.Contains(name);
		}

	}//end DB

}//end namespace Model