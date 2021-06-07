///////////////////////////////////////////////////////////
//  DeckT.cs
//  Implementation of the Class Deck<T>
//  Created on:      07-θών-2021 15:14:50
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



using Interfaces;
namespace Model {
	public class Deck<T> : IElementsQueue<T> {

		private Queue <T> _container;

		public int Count{
			get{ return _container.Count; }
		}

		/// 
		/// <param name="item"></param>
		public void Enqueue(T item){

			_container.Enqueue(item);
		}

		public IEnumerator<T> GetEnumerator(){

			return _container.GetEnumerator();
		}

		/// 
		/// <param name="item"></param>
		public bool Contains(T item){

			return _container.Contains(item);
		}

		public T Dequeue(){

			return _container.Dequeue();
		}

		/// 
		/// <param name="array"></param>
		/// <param name="arrayIndex"></param>
		public void CopyTo(T[] array, int arrayIndex = 0){

			_container.CopyTo(array, arrayIndex);
		}

		public T Peek(){

			try
			{
				return _container.Peek();
			}	
			catch (InvalidOperationException e)
			{
				return default(T);
			}
		}

		public void Clear(){

			_container.Clear();
		}

		/// 
		/// <param name="item"></param>
		public bool TryPeek(out T item){

			return _container.TryPeek(out item);
		}

		public Type GetTypeContainer(){

			return _container.GetType();
		}

		public T[] ToArray(){

			return _container.ToArray();
		}

		/// 
		/// <param name="arrayItems"></param>
		public   Deck(T[] arrayItems){

			Random rand = new Random();
			T[] newArrayItems = arrayItems.OrderBy(x => rand.Next()).ToArray();
	
			_container = new Queue<T>();
	
			foreach ( T item in arrayItems)
			{
				_container.Enqueue(item);
			}
		}

	}//end Deck<T>

}//end namespace Model