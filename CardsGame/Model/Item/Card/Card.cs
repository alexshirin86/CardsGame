///////////////////////////////////////////////////////////
//  Card.cs
//  Implementation of the Class Card
//  Created on:      04-θών-2021 16:46:42
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
using Interfaces;
namespace Model {
	public class Card {

				
		/// 
		/// <param name="id"></param>
		public Card(int id){

			CardDB card = DB.GetCard( id );
			Name = card.Name;
			Flavour = card.Flavour;
			Gold = new Gold(card.Gold);
			Crystal = new Crystal(card.Crystal);
	
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
			get; init;
		}

		public string Flavour{
			get; init;
		}

		public Gold Gold{
			get; init;
		}

		public string Name{
			get; init;
		}

	}//end Card

}//end namespace Model