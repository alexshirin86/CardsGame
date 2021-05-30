///////////////////////////////////////////////////////////
//  Item.cs
//  Implementation of the Class Item
//  Created on:      30-май-2021 3:35:44
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public abstract class Item {

		

		public abstract int Price{
			get;
			
		}

		public abstract string Name{
			get;
		}

	}//end Item

}//end namespace Model