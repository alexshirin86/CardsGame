///////////////////////////////////////////////////////////
//  MarketAdmin.cs
//  Implementation of the Class MarketAdmin
//  Created on:      29-май-2021 17:25:22
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketAdmin : Market {

		private Account _account;

		
		public override Account Account{
			get {
				return _account;
			}
		}

		public override void ShowItems(){

		}

	}//end MarketAdmin

}//end namespace Model