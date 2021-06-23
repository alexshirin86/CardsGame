using System;

namespace Model.Item {
	public class Product : Element  {
		private int gold;
		private int crystal;
		public int Price { get; }
		public override string Name { get; init; }
		private Card[] card;
		public override string ImagePath { get; init; }
		public override int Id { get; init; }


	}

}
