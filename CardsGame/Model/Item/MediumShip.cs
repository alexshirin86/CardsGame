using System;

namespace CardsGame.Model.Items {
	public class MediumShip : Card , CardsGame.Model.Interfaces.IShip  {
		public CardsGame.Model.Interfaces.IModule[] Modules { get; init; }
		public int Id { get; }
		public string Name { get; init; }
		public string Description { get; }
		public string ImagePath { get; init; }
		public int Atack { get; init; }
		public int HitPoint { get; init; }
		public int BonusHitPoint { get; init; }

		public bool HasModule(int index) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void SetModule(int index) {
			throw new System.NotImplementedException("Not implemented");
		}
		public CardsGame.Model.Interfaces.IModule GetModule(int index) {
			throw new System.NotImplementedException("Not implemented");
		}
		public MediumShip(int id) {
			Modules = new IModule[2];
		}

	}

}
