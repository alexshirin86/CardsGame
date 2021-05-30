///////////////////////////////////////////////////////////
//  Market.cs
//  Implementation of the Class Market
//  Created on:      29-май-2021 20:32:16
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public abstract class Market {

		

		
		public virtual void ShowItems(){

		}

		protected internal abstract Account Account{
			get;
			set;
		}

	}//end Market

}//end namespace Model