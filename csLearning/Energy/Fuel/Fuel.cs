using System;

namespace energy {
	namespace fuel {
		abstract class Fuel : Energy {
			protected readonly Double freezeBorder;
			protected Fuel( double calorific, double freezeBorder ): base(calorific) {
				this.freezeBorder = freezeBorder;
			}
			// returns count of getted energy
			override public Double Use( ref Double count ) {
				return Burn(ref count);
			}
			public abstract Double Burn( ref Double fuelCount );
		}
	}
}
