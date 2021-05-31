///////////////////////////////////////////////////////////
//  Game.cs
//  Implementation of the Class Game
//  Created on:      29-май-2021 22:03:54
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
		private bool exit = false;
		private Market _market;
		

		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		/// <summary>
		/// <ol>
		/// 	<li></li>
		/// </ol>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="pass"></param>
		public bool Login(string name, string pass){

			if(DB.HasUser(name, pass)){
				Launch(name);
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

		/// 
		/// <param name="name"></param>
		private void Launch(string name){

			Console.WriteLine($"\nДобро пожаловать, {name}!");
			Console.WriteLine("Вам доступно:");
			Console.Write("1. ");
		
			Type typeAccount = DB.GetTypeAccount(name);
			_account = new Account(DB.GetId(name), typeAccount);
	
			if (typeAccount == typeof(Admin)) {
				_market = new MarketAdmin(_account);
			}
			else if (typeAccount == typeof(Player)) {
				_market = new MarketPlayer(_account);
			}
				else if(typeAccount == typeof(Vip)) {
				_market = new MarketVip(_account);
			}

			Console.WriteLine("2. Играть партию");
			Console.WriteLine("3. Выход");

			string command;
			do
			{
				command = Console.ReadLine();
				switch (command)
				{
					case "1":
						_market.ShowProducts();
						break;
					case "2":
						
						break;
					case "3":
						Unlogin();
						break;
					default:
						Console.WriteLine("Попробуйте еще раз или введите 3 для выхода.");
						break;
				}				
			} while (!Exit);
		}

		private void Unlogin(){
			Exit = true;
		}

		public bool Exit{
			get {
				return exit;
			}
			set {
				exit = value;
			}
		}

	}//end Game

}//end namespace Model