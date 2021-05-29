///////////////////////////////////////////////////////////
//  MarketPlayer.cs
//  Implementation of the Class MarketPlayer
//  Created on:      29-май-2021 20:58:09
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
		public Model.Trash m_Trash;


		public MarketPlayer(){

			Trash trash = new Trash();
		}

		/// 
		/// <param name="account"></param>
		public MarketPlayer(Account account){

			Trash trash = new Trash();
			Account = account;
		}

		public override void ShowItems(){

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