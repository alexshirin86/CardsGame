using System;
using System.Runtime.InteropServices;

namespace Model.Item.Interface {
	public interface IElementsStack<T> : IElements<T>  {

		T Pop();
		/// <summary>
		/// &lt;param name="item"&gt;&lt;/param&gt;
		/// </summary>
		void Push(T item);
		T Peek();
		T TryPeek();
		T TryPop();
		// method ToArray is inherited from base class

		// method GetTypeContainer is inherited from base class

		// method Clear is inherited from base class

		// method CopyTo is inherited from base class

		// method Contains is inherited from base class

		// method GetEnumerator is inherited from base class


	}

}
