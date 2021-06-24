using System;

namespace Model.Item {
	public abstract class Card : Element  {
		public abstract string Description { get; init; }
		public override abstract int Id { get; init; }
		public override abstract string ImagePath { get; init; }
		public override abstract string Name { get; init; }
		public abstract int Cost { get; init; }

		public Card(int id) {
			Id = id;
			CardDB card = DB.GetCard( id );
			Name = card.Name;
			Description = card.Flavour;
		}


	}

}
