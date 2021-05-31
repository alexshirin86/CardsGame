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
		private int price;
		private List <Card> cards;
		private Crystal crystal;
		private Gold gold;
		private string name;


	
		public int Price{
			get {
				return price;
			}
		}

		public int GetGoldCount(){
			return gold.Count;
		}

		public int GetCrystalCount(){
			return crystal.Count;
		}
}//end Product

}//end namespace Model