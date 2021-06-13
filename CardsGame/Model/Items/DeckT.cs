///////////////////////////////////////////////////////////
//  DeckT.cs
//  Implementation of the Class Deck<T>
//  Created on:      09-θών-2021 16:55:25
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



using Interfaces;
using Model;
namespace Model {
	public class Deck<T> : Item, IElementsQueue<T> {

		private Queue <T> _container;

        public int Count {
            get { return _container.Count; }
        }

        /// <summary>
        ///   <param name="item"></param>
        /// </summary>
        public void Enqueue(T item)
        {

            _container.Enqueue(item);
        }

        public IEnumerator<T> GetEnumerator(){

			return _container.GetEnumerator();
		}

        public override string Name {
            get;
            init;
        }

        /// <summary>
        ///   <param name="item"></param>
        /// </summary>
        public bool Contains(T item)
        {

            return _container.Contains(item);
        }

        public T Dequeue(){

			return _container.Dequeue();
		}

        public override string ImagePath {
            get;
            init;
        }

        /// <summary>
        ///   <param name="array"></param>
        ///   <param name="arrayIndex"></param>
        /// </summary>
        public void CopyTo(T[] array, int arrayIndex = 0)
        {

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

        /// <summary>
        ///   <param name="item"></param>
        /// </summary>
        public bool TryPeek(out T item)
        {

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

	}

	

	

}//end namespace Model