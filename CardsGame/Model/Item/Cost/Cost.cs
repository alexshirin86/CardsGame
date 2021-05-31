///////////////////////////////////////////////////////////
//  Cost.cs
//  Implementation of the Class Cost
//  Created on:      31-май-2021 13:42:07
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Cost : Item {

		protected internal int count;
		protected internal string name;

		/// 
		/// <param name="count"></param>
		public Cost(int count){

			this.count = count;
		}

		public int Count{
			get{
				return count;
			}
			set{
				count = value;
			}
		}

		public override string Name{
			get {
				return name;
			}
		}

	}//end Cost

}//end namespace Model