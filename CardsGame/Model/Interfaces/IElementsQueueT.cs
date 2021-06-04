///////////////////////////////////////////////////////////
//  IElementsQueueT.cs
//  Implementation of the Interface IElementsQueue<T>
//  Created on:      04-θών-2021 16:43:46
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

		bool TryPeek();
	}//end IElementsQueue<T>

}//end namespace Interfaces