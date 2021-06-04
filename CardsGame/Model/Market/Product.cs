///////////////////////////////////////////////////////////
//  Product.cs
//  Implementation of the Class Product
//  Created on:      31-май-2021 12:51:34
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public class Product {
		//private int price;
		private List <Card> _cards;
		private Crystal _crystal;
		private Gold _gold;
		//private string name;

	
		public int Price{
			get; init;
		}

		public int Name {
			get; init;
		}

		public int GetGoldCount(){
			return _gold.Count;
		}

		public int GetCrystalCount(){
			return _crystal.Count;
		}
}//end Product

}//end namespace Model