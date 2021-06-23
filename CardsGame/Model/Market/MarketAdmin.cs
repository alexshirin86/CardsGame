
using System;
using System.Collections.Generic;
using Model.Interfaces;

namespace Model {
	public class MarketAdmin : IMarket
	{

        public MarketAdmin(IAccount account)
        {

            Account = account;
            Console.WriteLine("������� ��� ��������������");
        }

        public IAccount Account {
			get; init;
		}

		public void ShowProducts(){

			Console.WriteLine("\n��� ��������:");
			Console.WriteLine("������� ������");
			Console.WriteLine($"1. ������ {DB.GoldPrice}");
			Console.WriteLine($"2. ������� {DB.CrystalPrice}");
			Console.WriteLine("\n");
	
			Console.WriteLine("����������� ��� �������");
			List<ProductDB> products = DB.GetProductsMarketPlayer();
	
			int i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. ��������� ������ {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
	
			Console.WriteLine("����������� ��� ��� �������");
			products = DB.GetProductsMarketVip();
	
			i = 1;
			foreach (ProductDB product in products) {
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. ��������� ������ {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
		}

	}
}