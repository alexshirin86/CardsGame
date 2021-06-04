///////////////////////////////////////////////////////////
//  Deck.cs
//  Implementation of the Class Deck
//  Created on:      03-θών-2021 23:12:03
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Deck : IItemAction {

		public void Add(){

		}

		public IItem Take(){
			Card card = new Card(15);
			return card;
		}

		public void Move(){

		}

	}//end Deck

}//end namespace Model