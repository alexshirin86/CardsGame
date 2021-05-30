///////////////////////////////////////////////////////////
//  Entity.cs
//  Implementation of the Class Entity
//  Created on:      30-май-2021 4:55:57
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Entity : Card {

		/// 
		/// <param name="id"></param>
		public Entity(int id):base(id){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Entity(string name, string flavour, int gold, int crystal, int price): base(name, flavour, gold, crystal, price)
		{

		}

	}//end Entity

}//end namespace Model