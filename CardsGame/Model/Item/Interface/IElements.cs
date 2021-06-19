using System;
using System.Runtime.InteropServices;

namespace Model.Item.Interface {
	public interface IElements<T> {
		int Count { get; init; }

		System.Collections.Generic.IEnumerator<T> GetEnumerator();
		/// <summary>
		/// &lt;param name="item"&gt;&lt;/param&gt;
		/// </summary>
		bool Contains(T item);
		/// <summary>
		/// &lt;param name="array"&gt;&lt;/param&gt;
		/// &lt;param name="arrayIndex"&gt;&lt;/param&gt;
		/// </summary>
		void CopyTo(T[] array, [Optional, DefaultParameterValueAttribute(0)]int arrayIndex);
		void Clear();
		System.Type GetTypeContainer();
		T[] ToArray();

	}

}
