using System;

namespace Model.Item {
	[Serializable]
	public abstract class Element {
		public abstract int Id { get; init; }
		public abstract string Name { get; init; }
		public abstract string ImagePath { get; init; }

	}

}