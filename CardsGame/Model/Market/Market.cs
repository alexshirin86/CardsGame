///////////////////////////////////////////////////////////
//  Market.cs
//  Implementation of the Class Market
//  Created on:      31-���-2021 13:30:57
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

			Console.WriteLine("\n��� ��������:");
			Console.WriteLine("������� ������");	
			Console.WriteLine($"1. ������ {DB.GoldPrice}");
			Console.WriteLine($"2. ������� {DB.CrystalPrice}");
			Console.WriteLine("\n");
		}

		protected internal abstract Account Account{
			get;
			init;
		}

	}//end Market

}//end namespace Model