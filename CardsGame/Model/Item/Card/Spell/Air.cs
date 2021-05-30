///////////////////////////////////////////////////////////
//  Air.cs
//  Implementation of the Class Air
//  Created on:      30-май-2021 4:56:24
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Air : Spell {

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Air(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price)
		{

		}

		/// 
		/// <param name="id"></param>
		public Air(int id): base(id)
		{

		}

	}//end Air

}//end namespace Model