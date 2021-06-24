using System;
using System.Data.Linq.Mapping;

namespace Model.Item {
	[Table(Name = "Product")]
	public class Product : Element  {
		[Column]
		private int gold;
		[Column]
		private int crystal;
		public int Price { get; }
		[Column]
		public override string Name { get; init; }
		private Card[] card;
		[Column]
		public override string ImagePath { get; init; }
		[Column(IsPrimaryKey = true)]
		public override int Id { get; init; }

        Product(int id)
        {
			Id = id;

		}


	}

}
