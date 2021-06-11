///////////////////////////////////////////////////////////
//  Account.cs
//  Implementation of the Class Account
//  Created on:      07-июн-2021 13:19:18
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
using Interfaces;
namespace Model {
	public class Account : IAccount {

		private EnumTypeAccount typeAccount;

        /// <summary>
        ///   <param name="id"></param>
        ///   <param name="typeAccount"></param>
        /// </summary>
        public Account(int id, EnumTypeAccount typeAccount)
        {

            Money = DB.GetMoney(id);
            Disscount = DB.GetDisscount(id);
            this.typeAccount = typeAccount;
        }

        public int Money {
            get; private set;
        }

        public EnumTypeAccount TypeAccount{
			get; private set;
		}

        /// <summary>
        /// пополнение баланса картой
        /// </summary>
        /// <param name="number"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="cash"></param>
        public void AddFunds(int number, int month, int year, int cash)
        {

            DB.SetMoney(Id, cash);
        }

        public string Name {
            get; private set;
        }

        /// <summary>
        /// пополнение баланса PayPal
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pnumber"></param>
        /// <param name="cash"></param>
        public void AddFunds(string email, int pnumber, int cash)
        {

            DB.SetMoney(Id, cash);
        }

        public int Disscount {
            get; init;
        }

        public int Id {
            get; init;
        }

    }//end Account

}//end namespace Model