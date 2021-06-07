///////////////////////////////////////////////////////////
//  Product.cs
//  Implementation of the Class Product
//  Created on:      07-θών-2021 11:33:48
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Product {

		private Gold _gold;
		private Crystal _crystal;

		public int GetGoldCount(){

			return _gold.Count;
		}

		public int GetCrystalCount(){

			return _crystal.Count;
		}

		public int Price{
			get; init;
		}

		public string Name{
			get; init;
		}

		public Card[] Card{
			get; init;
		}

	}//end Product

}//end namespace Model