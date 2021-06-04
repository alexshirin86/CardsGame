///////////////////////////////////////////////////////////
//  Trash.cs
//  Implementation of the Class Trash
//  Created on:      31-���-2021 14:09:31
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Trash {

		//private int sum;
		private List <Product> _products;

		public Trash(){

			Sum = 0;
		}

		public void Pay(){

		}

		public int Sum {
			get; private set;
		}

		/// 
		/// <param name="product"></param>
		public void Add(Product product){

			_products.Add(product);
			Sum += product.Price;
		}

		/// 
		/// <param name="product"></param>
		public void Remove(Product product){

			_products.Remove(product);
			Sum -= product.Price;
		}

		public void Clear(){

			_products.Clear();
			Sum = 0;
		}

	}//end Trash

}//end namespace Model