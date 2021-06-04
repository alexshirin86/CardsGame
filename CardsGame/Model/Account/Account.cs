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

		
		private EnumTypeAccount typeAccount;

		/// 
		/// <param name="id"></param>
		/// <param name="type"></param>
		public Account(int id, EnumTypeAccount typeAccount)
		{

			Money = DB.GetMoney(id);
			Disscount = DB.GetDisscount(id);
			TypeAccount = typeAccount;
			
		}

		public int Money{
			get; private set;
		}

		public EnumTypeAccount TypeAccount {
			get; private set;
		}


		/// пополнение баланса картой
		/// </summary>
		/// <param name="number"></param>
		/// <param name="month"></param>
		/// <param name="year"></param>
		/// <param name="cash"></param>
		public void AddFunds(int number, int month, int year, int cash){

			DB.SetMoney( Id, cash );
		}

		public string Name{
			get; private set;
		}


		/// <summary>
		/// пополнение баланса PayPal
		/// </summary>
		/// <param name="email"></param>
		/// <param name="pnumber"></param>
		/// <param name="cash"></param>
		public void AddFunds(string email, int pnumber, int cash){

			DB.SetMoney( Id, cash );
		}

		public int Disscount{
			get; init;
		}

		public int Id{
			get; init;
		}

	}//end Account

}//end namespace Model