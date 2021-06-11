///////////////////////////////////////////////////////////
//  Weapon.cs
//  Implementation of the Class Weapon
//  Created on:      09-���-2021 16:18:56
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Weapon : Module {

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Weapon(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price){

		}

		/// 
		/// <param name="id"></param>
		public Weapon(int id) : base(id){

		}

	}//end Weapon

}//end namespace Model