///////////////////////////////////////////////////////////
//  Cost.cs
//  Implementation of the Class Cost
//  Created on:      09-θών-2021 16:50:51
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Cost : Item {

		/// 
		/// <param name="count"></param>
		public Cost(int count)
        {

			Count = count;
		}

        public int Count {
            get; protected set;
        }

        public override string ImagePath {
            get; init;
        }

        public override string Name {
            get; init;
        }

    }//end Cost

}//end namespace Model