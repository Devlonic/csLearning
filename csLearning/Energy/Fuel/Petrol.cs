using System;

namespace energy {
	namespace fuel {
		class Petrol : Fuel {
			public Petrol() : base(44.4, -60) { }
			public Petrol( Double calorificValue, Double freezeBorder ) :
				base(calorificValue, freezeBorder) {
			}
			public override Double Burn( ref Double fuelCountLiter ) {
				var fuelcounttemp = fuelCountLiter;
				fuelCountLiter = 0;
				return fuelcounttemp * base.GetCalorific();
			}
			public override String ToString() {
				return "Petrol";
			}
		}
	}
}
