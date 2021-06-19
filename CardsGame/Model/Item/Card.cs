using System;

namespace Model.Item {
	[Serializable]
	public abstract class Card : Item  {
		public abstract int Id { get; init; }
		public abstract string ImagePath { get; init; }
		public abstract string Description { get; init; }
		public abstract string Name { get; init; }

		/// <summary>
		/// <param name="id"></param>
		/// </summary>
		public Card(int id) {
			Id = id;
			CardDB card = DB.GetCard( id );
						Name = card.Name;
						Flavour = card.Flavour;
		}
		/// <summary>
		/// &lt;param name="name"&gt;&lt;/param&gt;
		/// &lt;param name="flavour"&gt;&lt;/param&gt;
		/// &lt;param name="gold"&gt;&lt;/param&gt;
		/// &lt;param name="crystal"&gt;&lt;/param&gt;
		/// &lt;param name="price"&gt;&lt;/param&gt;
		/// </summary>
		public Card(string name, string flavour, int gold, int crystal, int price) {
			throw new System.NotImplementedException("Not implemented");
		}


	}

}
