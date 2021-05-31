///////////////////////////////////////////////////////////
//  Account.cs
//  Implementation of the Class Account
//  Created on:      31-май-2021 17:35:38
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public class Account {

		private int money;
		private int id;
		private int disscount;
		private EnumTypeAccount typeAccount;
		private string name;

		/// 
		/// <param name="id"></param>
		/// <param name="type"></param>
		public Account(int id, EnumTypeAccount typeAccount)
		{

			money = DB.GetMoney(id);
			disscount = DB.GetDisscount(id);
			this.typeAccount = typeAccount;
			
		}

		public int Money{
			get { return money; }
		}

		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <param name="cash"></param>
		public void AddFunds(int number, int month, int year, int cash){

			DB.SetMoney( id, cash );
		}

		public string Name{
			get { return name; }
		}

		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <param name="cash"></param>
		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <param name="cash"></param>
		public void AddFunds(string email, int pnumber, int cash){

			DB.SetMoney( id, cash );
		}

		public int Disscount{
			get { return disscount; }
		}

		public int Id{
			get { return id; }
		}

	}//end Account

}//end namespace Model