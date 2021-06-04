///////////////////////////////////////////////////////////
//  MarketVip.cs
//  Implementation of the Class MarketVip
//  Created on:      31-���-2021 13:30:57
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketVip : MarketPlayer {

		/// 
		/// <param name="account"></param>
		public MarketVip(Account account){

			Trash trash = new Trash();
			Account = account;
			Console.WriteLine("������� ��� ��� �������");
		}

		public override void ShowProducts(){

			base.ShowProducts();
			Console.WriteLine("����������� ��� ��� �������");
			List<ProductDB> products = DB.GetProductsMarketVip();
	
			int i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. ��������� ������ {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
		}

	}//end MarketVip

}//end namespace Model