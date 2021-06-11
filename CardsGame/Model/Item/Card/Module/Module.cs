///////////////////////////////////////////////////////////
//  Module.cs
//  Implementation of the Class Module
//  Created on:      09-θών-2021 16:18:02
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Module : Card {

		/// 
		/// <param name="id"></param>
		public Module(int id) : base(id){

		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Module(string name, string flavour, int gold, int crystal, int price) : base(name, flavour, gold, crystal, price){

		}

	}//end Module

}//end namespace Model