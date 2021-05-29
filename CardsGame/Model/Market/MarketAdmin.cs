///////////////////////////////////////////////////////////
//  MarketAdmin.cs
//  Implementation of the Class MarketAdmin
//  Created on:      29-���-2021 21:09:19
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketAdmin : Market {

		private Account account;

		
		/// 
		/// <param name="account"></param>
		public MarketAdmin(Account account){

			Account = account;
			Console.WriteLine("������� ��� ��������������");
		}

		public override void ShowItems(){

		}

		protected internal override Account Account{
			get {
				return account;
			}
			set {
				account = value;
			}
		}

	}//end MarketAdmin

}//end namespace Model