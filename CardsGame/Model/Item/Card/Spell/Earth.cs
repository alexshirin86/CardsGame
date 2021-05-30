///////////////////////////////////////////////////////////
//  Earth.cs
//  Implementation of the Class Earth
//  Created on:      30-май-2021 4:56:24
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Earth : Spell {

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Earth(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price)
		{

		}

		/// 
		/// <param name="id"></param>
		public Earth(int id) : base(id)
		{

		}

	}//end Earth

}//end namespace Model