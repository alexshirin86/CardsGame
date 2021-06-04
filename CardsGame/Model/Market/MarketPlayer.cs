///////////////////////////////////////////////////////////
//  MarketPlayer.cs
//  Implementation of the Class MarketPlayer
//  Created on:      31-май-2021 13:30:58
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketPlayer : Market {

		protected internal Trash _trash;
		
		

		public MarketPlayer(){

			Trash trash = new Trash();
		}

		/// 
		/// <param name="account"></param>
		public MarketPlayer(Account account){

			Trash trash = new Trash();
			Account = account;
			Console.WriteLine("Магазин для игроков");
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
		}

		public void AddInTrash(){

		}


	}//end MarketPlayer

}//end namespace Model