using System;

namespace Model.Item.Interface {
	public interface IShip {
		IModule[] Modules { get; init; }
		int Atack { get; init; }
		int HitPoint { get; init; }
		int BonusHitPoint { get; init; }

		IModule GetModule(int index);
		void SetModule(int index);
		bool HasModule(int index);

	}

}
