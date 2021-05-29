///////////////////////////////////////////////////////////
//  Cost.cs
//  Implementation of the Class Cost
//  Created on:      29-май-2021 15:41:01
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Cost : Item {

		internal protected int count;
		internal protected int price;

		public Cost(){

		}

		~Cost(){

		}

		public int Count{
			get{
				return count;
			}
			set{
				count = value;
			}
		}

		public override int Price{
			get{
				return price;
			}
		}

	}//end Cost

}//end namespace Model