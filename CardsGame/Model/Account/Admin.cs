///////////////////////////////////////////////////////////
//  Admin.cs
//  Implementation of the Class Admin
//  Created on:      31-май-2021 13:55:49
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public class Admin : User {

		protected internal string name;

		public override string Name{
			get { return name; }
		}

	}//end Admin

}//end namespace Model