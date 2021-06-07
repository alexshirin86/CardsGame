///////////////////////////////////////////////////////////
//  IElementsQueueT.cs
//  Implementation of the Interface IElementsQueue<T>
//  Created on:      07-θών-2021 14:53:08
//  Original author: Lucky
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Interfaces;
namespace Interfaces {
	public interface IElementsQueue<T> : IElements<T>  {

		/// 
		/// <param name="item"></param>
		void Enqueue(T item);

		T Dequeue();

		T Peek();

		/// 
		/// <param name="item"></param>
		bool TryPeek(out T item);
	}//end IElementsQueue<T>

}//end namespace Interfaces