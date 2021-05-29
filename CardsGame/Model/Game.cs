///////////////////////////////////////////////////////////
//  Game.cs
//  Implementation of the Class Game
//  Created on:      29-май-2021 17:54:26
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Game {

		private Account account;
		private string password;
		private string nameUser;
		private Room room;
		private Market market;

		public Game(){

		}

		~Game(){

		}

		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public bool Login(string name, string pass){

			if(DB.HasUser(name, pass)){
				Account _account = new Account(DB.GetId(name), DB.GetTypeAccount(name));
				return true;
			}
			return false;
		}

		public void NewAccount(){

		}

		public Account Account{
			get {
				return account;
			}
		}

		public void Unlogin(){

		}

	}//end Game

}//end namespace Model