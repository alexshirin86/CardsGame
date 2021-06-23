using System;
using Model.Item.Interface;

namespace Model.Item {
	public abstract class LightShip : Card , IShip  {
		public IModule[] Modules { get; init; }
		public override int Id { get; init; }
		public override string Name { get; init; }
		public override string ImagePath { get; init; }
		public override abstract string Description { get; init; }
		public int Attack { get; init; }
		public int Armor { get; init; }
		public int Shield { get; init; }
		public override int Cost { get; init; }

		public IModule GetModule(int index) {
			try
			{
				return Modules[index];
			}
			catch (IndexOutOfRangeException e)
			{
				return null;
			}
		}
		public bool SetModule(int index, IModule module) {
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
		public bool? HasModule(int index) {
			try {
			   	return Modules[index] != null ? true : false;
			} 
			catch (IndexOutOfRangeException e) {
				return null;
			}
		}
		public LightShip(int id):base(id) {
			Modules = new IModule[1];
		}
		public bool SetModule(IModule module) {
			Modules[0] = module;
			return true;
		}
		public bool? HasModule() {
			return Modules[0] != null ? true : false;
		}
		public IModule GetModule() {
			return Modules[0];
		}

	}

}
