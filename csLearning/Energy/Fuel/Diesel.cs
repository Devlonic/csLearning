using System;

namespace energy {
	namespace fuel {
		class Diesel : Fuel {
			public Diesel() :
				base(42.624, -5) {
			}
			public Diesel( Double calorificValue, Double freezeBorder ) :
				base(calorificValue, freezeBorder) {
			}
			public override Double Burn( ref Double fuelCountLiter ) {
				var fuelcounttemp = fuelCountLiter;
				fuelCountLiter = 0;
				return fuelcounttemp * base.GetCalorific();
			}
			public override String ToString() {
				return "Diesel";
			}
		}
	}
}
