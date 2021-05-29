///////////////////////////////////////////////////////////
//  DB.cs
//  Implementation of the Class DB
//  Created on:      29-май-2021 17:48:43
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class DB {

		
		private static int crystalPrice = 100;

		public DB(){

		}

		~DB(){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public static bool HasUser(string name, string pass){

			return true;
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

	}//end DB

}//end namespace Model