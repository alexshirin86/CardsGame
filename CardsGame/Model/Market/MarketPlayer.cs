///////////////////////////////////////////////////////////
//  MarketPlayer.cs
//  Implementation of the Class MarketPlayer
//  Created on:      29-май-2021 17:25:22
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketPlayer : Market {

		protected internal Account account;
		protected internal Trash trash;
		

		
		public MarketPlayer(){

			Trash trash = new Trash();
		}

		public override Account Account{
			get {
				return account;
			}
		}

		public void AddInTrash(){

		}

		public override void ShowItems(){

		}

	}//end MarketPlayer

}//end namespace Model