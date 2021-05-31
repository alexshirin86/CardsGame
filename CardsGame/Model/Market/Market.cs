///////////////////////////////////////////////////////////
//  Market.cs
//  Implementation of the Class Market
//  Created on:      29-май-2021 20:32:16
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public abstract class Market {

		

		
		public virtual void ShowItems(){
			Console.WriteLine($"\nВам доступно:");
			Console.WriteLine($"Игровая валюта");			
			Console.WriteLine($"1. Золото {DB.GoldPrice}");
			Console.WriteLine($"2. Кристал {DB.CrystalPrice}");
			Console.WriteLine("\n");
		}

		protected internal abstract Account Account{
			get;
			set;
		}

	}//end Market

}//end namespace Model