///////////////////////////////////////////////////////////
//  Spell.cs
//  Implementation of the Class Spell
//  Created on:      30-май-2021 4:56:23
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Spell : Card {

		/// 
		/// <param name="id"></param>
		public Spell(int id) : base(id)
		{

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Spell(string name, string flavour, int gold, int crystal, int price):base(name, flavour, gold, crystal, price)
		{

		}

	}//end Spell

}//end namespace Model