///////////////////////////////////////////////////////////
//  MarketVip.cs
//  Implementation of the Class MarketVip
//  Created on:      29-���-2021 21:09:18
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketVip : MarketPlayer {

		private int disscount;

		

		/// 
		/// <param name="account"></param>
		public MarketVip(Account account){

			Trash trash = new Trash();
			Account = account;
			Console.WriteLine("������� ��� ��� �������");
		}

		public override void ShowItems(){

			base.ShowItems();
		}

	}//end MarketVip

}//end namespace Model