using System;
using Model.Item.Interface;

namespace Model.Item {
	public class MediumShip : Card , IShip  {
		public Model.Item.Interface.IModule[] Modules { get; init; }
		public override int Id { get; init; }
		public override string Name { get; init; }
		public override string ImagePath { get; init; }
		public override string Description { get; init; }
		public int Attack { get; init; }
		public int Armor { get; init; }
		public int Shield { get; init; }
		public override int Cost { get; init; }

		public bool? HasModule(int index) {
			try
			{
				return Modules[index] != null ? true : false;
			}
			catch (IndexOutOfRangeException e)
			{
				return null;
			}
		}
		public bool SetModule(int index, Model.Item.Interface.IModule module) {
			try
			{
				Modules[index] = module;
				return true;
			}
			catch (IndexOutOfRangeException e)
			{
				return false;
			}
		}
		public Model.Item.Interface.IModule GetModule(int index) {
			try
			{
				return Modules[index];
			}
			catch (IndexOutOfRangeException e)
			{
				return null;
			}
		}
		public MediumShip(int id): base(id) {
			Modules = new IModule[2];
		}

	}

}
