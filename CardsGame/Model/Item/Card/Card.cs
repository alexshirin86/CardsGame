///////////////////////////////////////////////////////////
//  Card.cs
//  Implementation of the Class Card
//  Created on:      30-май-2021 4:57:55
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Card : Item {

		protected internal int id;
		protected internal int price;
		protected internal string name;
		protected internal string flavour;
		protected internal Gold gold;
		protected internal Crystal crystal;

		/// 
		/// <param name="id"></param>
		public Card(int id){

			CardDB card = DB.GetCard( id );
			name = card.Name;
			flavour = card.Flavour;
			gold = new Gold(card.Gold);
			crystal = new Crystal(card.Crystal);
			price = card.Price;
		}

		/// 
		/// <param name="name"></param>
		/// <param name="flavour"></param>
		/// <param name="gold"></param>
		/// <param name="crystal"></param>
		/// <param name="price"></param>
		public Card(string name, string flavour, int gold, int crystal, int price){

		}

		public Crystal Crystal{
			get {
				return crystal;
			}
		}

		public string Flavour{
			get {
				return flavour;
			}
		}

		public Gold Gold{
			get {
				return gold;
			}
		}

		public override string Name{
			get {
				return name;
			}
		}

		public override int Price{
			get {
				return price;
			}
		}

	}//end Card

}//end namespace Model