///////////////////////////////////////////////////////////
//  Crystal.cs
//  Implementation of the Class Crystal
//  Created on:      29-май-2021 15:41:12
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Crystal : Cost {

		



		~Crystal(){

		}

		public Crystal(){

			price = DB.CrystalPrice;
		}


	}//end Crystal

}//end namespace Model