///////////////////////////////////////////////////////////
//  IElementsT.cs
//  Implementation of the Interface IElements<T>
//  Created on:      04-θών-2021 18:23:23
//  Original author: Lucky
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Interfaces {
	public interface IElements<T>
    {
        int Count {
            get;
        }

        IEnumerator<T> GetEnumerator();
        bool Contains(T item);

        /// <summary>
        ///   <param name="array"></param>
        ///   <param name="arrayIndex"></param>
        /// </summary>
        void CopyTo(T[] array, int arrayIndex = 0);

        void Clear();

		Type GetTypeContainer();

		T[] ToArray();
	}//end IElements<T>

}//end namespace Interfaces