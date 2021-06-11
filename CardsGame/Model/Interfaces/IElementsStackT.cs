///////////////////////////////////////////////////////////
//  IElementsStackT.cs
//  Implementation of the Interface IElementsStack<T>
//  Created on:      04-θών-2021 16:33:12
//  Original author: Lucky
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Interfaces;
namespace Interfaces {
	public interface IElementsStack<T> : IElements<T>  {

		T Pop();

        /// <summary>
        ///   <param name="item"></param>
        /// </summary>
        void Push(T item);

        T Peek();

		T TryPeek();

		T TryPop();
	}//end IElementsStack<T>

}//end namespace Interfaces