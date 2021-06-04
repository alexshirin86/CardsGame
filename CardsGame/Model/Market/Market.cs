///////////////////////////////////////////////////////////
//  Market.cs
//  Implementation of the Class Market
//  Created on:      31-май-2021 13:30:57
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public abstract class Market {

		

		public virtual void ShowProducts(){

			Console.WriteLine("\nВам доступно:");
			Console.WriteLine("Игровая валюта");	
			Console.WriteLine($"1. Золото {DB.GoldPrice}");
			Console.WriteLine($"2. Кристал {DB.CrystalPrice}");
			Console.WriteLine("\n");
		}

		protected internal abstract Account Account{
			get;
			init;
		}

	}//end Market

}//end namespace Model