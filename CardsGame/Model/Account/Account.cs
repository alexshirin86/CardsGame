///////////////////////////////////////////////////////////
//  Account.cs
//  Implementation of the Class Account
//  Created on:      31-май-2021 13:39:50
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
		private User _user;
		private int id;
		private int disscount;
		public Model.User m_User;

		/// 
		/// <param name="id"></param>
		/// <param name="type"></param>
		public Account(int id, Type type){

			_money = DB.GetMoney(id);
			disscount = DB.GetDisscount(id);
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
			get { return id; }
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
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
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
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		public void AddFunds(string email, int pnumber){

		}

		public int Disscount{
			get { return disscount; }
		}

	}//end Account

}//end namespace Model