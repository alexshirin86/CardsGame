///////////////////////////////////////////////////////////
//  Trash.cs
//  Implementation of the Class Trash
//  Created on:      31-май-2021 14:09:31
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Trash {

		private int sum;
		private List <Product> products;

		public Trash(){

			sum = 0;
		}

		public void Pay(){

		}

		/// 
		/// <param name="product"></param>
		public void Add(Product product){

			products.Add(product);
			sum += product.Price;
		}

		/// 
		/// <param name="product"></param>
		public void Remove(Product product){

			products.Remove(product);
			sum -= product.Price;
		}

		public void Clear(){

			products.Clear();
			sum = 0;
		}

	}//end Trash

}//end namespace Model