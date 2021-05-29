///////////////////////////////////////////////////////////
//  User.cs
//  Implementation of the Class User
//  Created on:      29-май-2021 15:38:00
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public abstract class User {

		protected internal string _name;
		private int type;
		public Model.Game m_Game;

		public User(){

		}

		~User(){

		}

		/// 
		/// <param name="name"></param>
		public User(string name){

		}

		public abstract string Name{
			get;
		}

	}//end User

}//end namespac-e Model