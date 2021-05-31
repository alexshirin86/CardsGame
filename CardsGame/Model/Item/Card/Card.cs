///////////////////////////////////////////////////////////
//  Card.cs
//  Implementation of the Class Card
//  Created on:      31-май-2021 13:22:02
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
		protected internal string name;
		protected internal string flavour;
		protected internal Gold gold;
		protected internal Crystal crystal;
		public Model.Deck m_Deck;

		/// 
		/// <param name="id"></param>
		public Card(int id){

			CardDB card = DB.GetCard( id );
			name = card.Name;
			flavour = card.Flavour;
			gold = new Gold(card.Gold);
			crystal = new Crystal(card.Crystal);
			
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

	}//end Card

}//end namespace Model