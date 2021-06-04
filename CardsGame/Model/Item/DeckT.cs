///////////////////////////////////////////////////////////
//  DeckT.cs
//  Implementation of the Class Deck<T>
//  Created on:      04-θών-2021 18:20:12
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



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

			return _container.Peek();
		}

		public void Clear(){

			_container.Clear();
		}

		public bool TryPeek(){

			return false;
		}

		public Type GetTypeContainer(){

			return _container.GetType();
		}

		public T[] ToArray(){

			return _container.ToArray();
		}

		/// 
		/// <param name="array"></param>
		public   Deck(Array array){

			
		}

	}//end Deck<T>

}//end namespace Model