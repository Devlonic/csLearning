// todo

using System;

namespace energy {
	namespace electricity {
		class Electricity : Energy {
			public Electricity( double calorificValue ) : base(calorificValue) {}

			public override double Use( ref double count ) {
				throw new NotImplementedException();
			}
		}
	}
}
