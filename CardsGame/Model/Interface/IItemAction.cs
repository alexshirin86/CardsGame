///////////////////////////////////////////////////////////
//  IItemAction.cs
//  Implementation of the Interface IItemAction
//  Created on:      03-θών-2021 23:37:45
//  Original author: Oleksii Shyrin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Model;
namespace Model {
	public interface IItemAction  {

		void Add();

		/// 
		/// <param name="index"></param>
		IItem Take(int index);

		void Move();

		IItem TakeFist();

		IItem TakeLast();

		IItem TakeNext();

		IItem TakePrev();
	}//end IItemAction

}//end namespace Model