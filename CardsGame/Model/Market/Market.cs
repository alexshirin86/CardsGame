///////////////////////////////////////////////////////////
//  Market.cs
//  Implementation of the Class Market
//  Created on:      29-май-2021 17:25:21
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public abstract class Market {

		private Account _account;
		public Model.Account m_Account;

		
		public abstract Account Account{
			get;
		}

		public virtual void ShowItems(){

		}

	}//end Market

}//end namespace Model