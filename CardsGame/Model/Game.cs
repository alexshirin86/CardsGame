///////////////////////////////////////////////////////////
//  Game.cs
//  Implementation of the Class Game
//  Created on:      29-май-2021 19:43:39
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Game {

		private Account _account;
		private Room _room;
		private Market _market;

		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public bool Login(string name, string pass){

			if(DB.HasUser(name, pass)){
				_account = new Account(DB.GetId(name), DB.GetTypeAccount(name));
				return true;
			}
			return false;
		}

		/// 
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public bool NewAccount(string name, string pass){

			return DB.NewAccount(name)? Login(name, pass): false;
		}

		public Account Account{
			get {
				return _account;
			}
		}

		public void Unlogin(){

		}

	}//end Game

}//end namespace Model