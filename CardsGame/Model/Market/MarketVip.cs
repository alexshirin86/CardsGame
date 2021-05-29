///////////////////////////////////////////////////////////
//  MarketVip.cs
//  Implementation of the Class MarketVip
//  Created on:      29-май-2021 17:25:21
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class MarketVip : MarketPlayer {

		private int disscount;



		~MarketVip(){

		}

		public MarketVip():base(){

			
		}

		public override void ShowItems(){

			base.ShowItems();
		}

	}//end MarketVip

}//end namespace Model