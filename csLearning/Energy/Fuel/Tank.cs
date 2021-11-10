using System;

namespace energy {
	namespace fuel {
		class Tank {
			private Fuel fuel = null;
			private Double value = 0;
			private readonly Double maxValue;
			private Boolean empty = true;
			private Double fuelInPipe = 0;

			public Fuel GetCurrentFuel() {
				return fuel;
			}
			public Boolean isEmpty() {
				return empty;
			}
			public Tank( double maxValue ) {
				this.maxValue = maxValue;
			}
			public ref Double Drain( Double count ) {
				if( count >= value ) {
					fuelInPipe = value;
					value = 0;
					empty = true;
				} else {
					value -= count;
					fuelInPipe = count;
				}
				return ref fuelInPipe;
			}
			public void Fill( Fuel fuel, Double value ) {
				if( this.empty ) {
					this.fuel = fuel;
					if( value > maxValue ) {
						this.value = maxValue;
					} else {
						this.value = value;
					}
					empty = false;
				} else {
					this.fuel = new Badfuel();
					if( value > maxValue ) {
						this.value = maxValue;
					} else {
						this.value = value;
					}
				}


			}
		}
	}
}
