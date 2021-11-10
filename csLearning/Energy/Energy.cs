using System;

namespace energy {
	abstract class Energy {
		protected readonly Double calorificValue;
		public Double GetCalorific() {
			return calorificValue;
		}
		protected Energy( double calorificValue ) {
			this.calorificValue = calorificValue;
		}
		public abstract Double Use( ref Double count );
	}
}
