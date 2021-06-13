///////////////////////////////////////////////////////////
//  Shield.cs
//  Implementation of the Class Shield
//  Created on:      09-θών-2021 16:19:08
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Shield : Module {

		/// 
		/// <param name="id"></param>
		public Shield(int id) : base(id){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Shield(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price){

		}

	}//end Shield

}//end namespace Model