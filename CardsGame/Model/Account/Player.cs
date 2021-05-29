///////////////////////////////////////////////////////////
//  Player.cs
//  Implementation of the Class Player
//  Created on:      29-май-2021 15:38:19
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Player : User {

		protected internal string _name;
		private List <Deck> Decks;

		
		public override string Name{
			get{
				return _name;
			}
		}

	}//end Player

}//end namespace Model