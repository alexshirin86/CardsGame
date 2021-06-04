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
	public class Cost {

		/// 
		/// <param name="count"></param>
		public Cost(int count){

			this.Count = count;
		}

		public int Count{
			get; protected internal set;
		
		}

		public string Name{
			get; init;
		}

	}//end Cost

}//end namespace Model