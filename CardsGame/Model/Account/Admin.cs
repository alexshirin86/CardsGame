///////////////////////////////////////////////////////////
//  Admin.cs
//  Implementation of the Class Admin
//  Created on:      29-май-2021 15:38:08
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Admin : User {

		protected internal string _name;

		public Admin(){

		}

		~Admin(){

		}

		public override string Name{
			get{
				return _name;
			}
		}

	}//end Admin

}//end namespace Model