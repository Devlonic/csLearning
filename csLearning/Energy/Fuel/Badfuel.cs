using System;

namespace energy {
	namespace fuel {
		class Badfuel : Fuel {
			public Badfuel() : base(0, -1) { }
			public override Double Burn( ref Double fuelCountLiter ) {
				return 0;
			}
			public override String ToString() {
				return "Bad fuel";
			}
		}
	}
}
