///////////////////////////////////////////////////////////
//  Player.cs
//  Implementation of the Class Player
//  Created on:      31-май-2021 13:53:08
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Player : User {

		private List <Deck> Decks;
		protected internal string name;

		public override string Name{
			get {return name;}
		}

	}//end Player

}//end namespace Model