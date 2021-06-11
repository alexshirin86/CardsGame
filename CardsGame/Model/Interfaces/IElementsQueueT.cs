///////////////////////////////////////////////////////////
//  IElementsQueueT.cs
//  Implementation of the Interface IElementsQueue<T>
//  Created on:      09-θών-2021 16:44:19
//  Original author: Lucky
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Interfaces;
namespace Interfaces {
	public interface IElementsQueue<T> : IElements<T>
    {

        /// <summary>
        ///   <param name="item"></param>
        /// </summary>
        void Enqueue(T item);

        T Dequeue();

		T Peek();
        bool TryPeek(out T item);
    }//end IElementsQueue<T>

}//end namespace Interfaces