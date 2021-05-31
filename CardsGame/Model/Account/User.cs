///////////////////////////////////////////////////////////
//  User.cs
//  Implementation of the Class User
//  Created on:      31-май-2021 13:55:49
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Model {
	public abstract class User {

		private int type;

		public abstract string Name{
			get;
		}

	}//end User

}//end namespace Model