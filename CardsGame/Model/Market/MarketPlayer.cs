///////////////////////////////////////////////////////////
//  MarketPlayer.cs
//  Implementation of the Class MarketPlayer
//  Created on:      29-май-2021 21:09:18
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketPlayer : Market {

		protected internal Trash trash;
		protected internal Account account;
		
		public MarketPlayer(){

			Trash trash = new Trash();
		}

		/// 
		/// <param name="account"></param>
		public MarketPlayer(Account account){

			Trash trash = new Trash();
			Account = account;
			Console.WriteLine("Магазин для игроков");
		}

		public override void ShowItems(){
			base.ShowItems();
			Console.WriteLine("Игровые карты");
			List<CardDB> cards = DB.GetCardsMarketPlayer();

			int i = 1;
			foreach (CardDB card in cards) {
				Console.WriteLine( $"{i}. {card.Name} {card. Price}");
				i++;
			}
			Console.WriteLine("\n");
		}

		public void AddInTrash(){

		}

		protected internal override Account Account{
			get {
				return account;
			}
			set {
				account = value;
			}
		}

	}//end MarketPlayer

}//end namespace Model