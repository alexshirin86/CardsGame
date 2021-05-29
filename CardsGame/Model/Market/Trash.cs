///////////////////////////////////////////////////////////
//  Trash.cs
//  Implementation of the Class Trash
//  Created on:      29-май-2021 17:16:52
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Trash {

		private List <Item> items;
		private int sum;



		~Trash(){

		}

		public Trash(){

			sum = 0;
		}

		/// 
		/// <param name="item"></param>
		public void Add(Item item){

			items.Add(item);
			sum += item.Price;
		}

		public void Clear(){

			items.Clear();
			sum = 0;
		}

		public void Pay(){

		}

		/// 
		/// <param name="item"></param>
		public void Remove(Item item){

			items.Remove(item);
			sum -= item.Price;
		}

	}//end Trash

}//end namespace Model