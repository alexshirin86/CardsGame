///////////////////////////////////////////////////////////
//  Card.cs
//  Implementation of the Class Card
//  Created on:      29-май-2021 17:07:24
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Card : Item {

		protected internal string flavour;
		protected internal int id;
		protected internal string name;
		protected internal int price;
		public Model.Deck m_Deck;

		
		public  string Flavour{
			get{
				return flavour;
			}
		}

		public int Id{
			get{
				return id;
			}
		}

		public string Name{
			get{
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