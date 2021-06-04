///////////////////////////////////////////////////////////
//  MarketAdmin.cs
//  Implementation of the Class MarketAdmin
//  Created on:      31-май-2021 13:30:58
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketAdmin : Market {

		
		/// 
		/// <param name="account"></param>
		public MarketAdmin(Account account){

			Account = account;
			Console.WriteLine("Магазин для администратора");
		}

		public override void ShowProducts(){

			base.ShowProducts();
			Console.WriteLine("Предложения для игроков");
			List<ProductDB> products = DB.GetProductsMarketPlayer();
	
			int i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. Доступная скидка {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
	
			Console.WriteLine("Предложения для вип игроков");
			products = DB.GetProductsMarketVip();
	
			i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. Доступная скидка {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
		}

		

	}//end MarketAdmin

}//end namespace Model