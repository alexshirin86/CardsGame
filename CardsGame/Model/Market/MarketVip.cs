using System;
using System.Collections.Generic;
using Model.Interfaces;

namespace Model {
	public class MarketVip : MarketPlayer
    {

        public MarketVip(IAccount account)
        {

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
				Console.WriteLine( $"{i}. {product.Name} {product. Price}. ��������� ������ {Account.Disscount}.");
				i++;
			}
	
			Console.WriteLine("\n");
		}

	}

}