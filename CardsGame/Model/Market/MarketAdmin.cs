///////////////////////////////////////////////////////////
//  MarketAdmin.cs
//  Implementation of the Class MarketAdmin
//  Created on:      07-июн-2021 14:36:48
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Interfaces;
namespace Model {
	public class MarketAdmin : IMarket
    {

        /// <summary>
        ///   <param name="account"></param>
        /// </summary>
        public MarketAdmin(IAccount account)
        {

            Account = account;
            Console.WriteLine("Магазин для администратора");
        }

        public IAccount Account{
			get; init;
		}

		public void ShowProducts(){

			Console.WriteLine("\nВам доступно:");
			Console.WriteLine("Игровая валюта");
			Console.WriteLine($"1. Золото {DB.GoldPrice}");
			Console.WriteLine($"2. Кристал {DB.CrystalPrice}");
			Console.WriteLine("\n");
	
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