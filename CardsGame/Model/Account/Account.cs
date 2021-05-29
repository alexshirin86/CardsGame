///////////////////////////////////////////////////////////
//  Account.cs
//  Implementation of the Class Account
//  Created on:      29-май-2021 17:54:26
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Account {

		private int _money;
		private int _id;
		private User _user;
		public Model.User m_User;

		public Account(){

		}

		~Account(){

		}

		/// 
		/// <param name="id"></param>
		/// <param name="type"></param>
		public Account(int id, Type type){

		}

		/// 
		/// <param name="user"></param>
		public Account(Player user){

		}

		/// 
		/// <param name="user"></param>
		public Account(Admin user){

		}

		public int Id{
			get{
				return _id;
			}
		}

		public int Money{
			get{
				return Money;
			}
			set{
				Money = value;
			}
		}

		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		public void AddFunds(int number, int month, int year){

		}

		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		public void AddFunds(string email, int pnumber){

		}

	}//end Account

}//end namespace Model