///////////////////////////////////////////////////////////
//  Armor.cs
//  Implementation of the Class Armor
//  Created on:      09-θών-2021 16:18:45
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Armor : Module {

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Armor(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price){

		}

		/// 
		/// <param name="id"></param>
		public Armor(int id) : base(id){

		}

	}//end Armor

}//end namespace Model