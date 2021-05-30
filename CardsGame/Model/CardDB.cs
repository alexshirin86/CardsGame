///////////////////////////////////////////////////////////
//  CardDB.cs
//  Implementation of the Class CardDB
//  Created on:      30-май-2021 3:58:10
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	/// <summary>
	/// Включено для текущей версии
	/// </summary>
	public struct CardDB   {

		private string name;

		private string flavour;

		private int crystal;

		private int gold;

		private int price;

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public CardDB(string name, string flavour, int gold, int crystal, int price){

			this.name = name;
			this.flavour = flavour;
			this.gold = gold;
			this.crystal = crystal;
			this.price = price;
		}

		public string Name{
			get {
				return name;
			}
	
		}

		public string Flavour{
			get {
				return flavour;
			}
	
		}

		public int Gold{
			get {
				return gold;
			}
	
		}

		public int Crystal{
			get {
				return crystal;
			}
	
		}

		public int Price{
			get {
				return price;
			}
	
		}

	}//end CardDB

}//end namespace Model