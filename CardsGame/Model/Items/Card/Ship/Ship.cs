///////////////////////////////////////////////////////////
//  Ship.cs
//  Implementation of the Class Ship
//  Created on:      09-θών-2021 16:17:26
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Ship : Card {

		/// 
		/// <param name="id"></param>
		public Ship(int id) : base(id){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Ship(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price){

		}

	}//end Ship

}//end namespace Model