///////////////////////////////////////////////////////////
//  Fire.cs
//  Implementation of the Class Fire
//  Created on:      30-май-2021 4:56:23
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Fire : Spell {

		/// 
		/// <param name="id"></param>
		public Fire(int id):base(id){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Fire(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price)
		{

		}

	}//end Fire

}//end namespace Model