using System;

namespace Items {
	[Serializable]
	public abstract class Item {
		public abstract string Name { get; init; }
		public abstract string ImagePath { get; init; }

	}

}
