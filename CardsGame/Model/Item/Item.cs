using System;

namespace CardsGame.Model.Items {
	[Serializable]
	public abstract class Item {
		public abstract int Id { get; init; }
		public abstract string Name { get; init; }
		public abstract string ImagePath { get; init; }

	}

}
