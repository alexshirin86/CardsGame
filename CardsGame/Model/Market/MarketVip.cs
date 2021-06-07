///////////////////////////////////////////////////////////
//  MarketVip.cs
//  Implementation of the Class MarketVip
//  Created on:      07-���-2021 14:36:48
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Interfaces;
using Model;
namespace Model {
	public class MarketVip : MarketPlayer {

		/// 
		/// <param name="account"></param>
		public MarketVip(IAccount account){

			Trash trash = new Trash();
			Account = account;
			Console.WriteLine("������� ��� ��� �������");
		}

		public new void ShowProducts(){

			base.ShowProducts();
			Console.WriteLine("����������� ��� ��� �������");
			List<ProductDB> products = DB.GetProductsMarketVip();
	
			int i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. ��������� ������ {account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
		}

	}//end MarketVip

}//end namespace Model