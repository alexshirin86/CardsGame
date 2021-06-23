using System;
using System.Collections.Generic;
using Model.Interfaces;

namespace Model {
	public class MarketPlayer : IMarket {

		protected internal Trash _trash;
		protected internal Model.Trash m_Trash;

		public MarketPlayer(){

			Trash trash = new Trash();
		}

        public MarketPlayer(IAccount account)
        {

            Trash trash = new Trash();
            Account = account;
            Console.WriteLine("������� ��� �������");
        }

        public IAccount Account{
			get;init;
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
		}

		public void AddInTrash(){

		}

	}

}