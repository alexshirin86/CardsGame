///////////////////////////////////////////////////////////
//  Item.cs
//  Implementation of the Class Item
//  Created on:      29-май-2021 15:39:50
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public abstract class Item {

		private int price;

		public Item(){

		}

		~Item(){

		}

		public abstract int Price{
			get;
		}

	}//end Item

}//end namespace Model