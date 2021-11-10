using System;

namespace transport {
	namespace land {
		namespace car {
			class Car : transport.land.Land {
				protected Engine engine = null;
				protected String title = "";
				protected Tank tank = null;
				private readonly Double amountOfFuelMixture = 0;
				Car( Engine engine, String title, Tank tank, double amountOfFuelMixture ) {
					this.engine = engine;
					this.title = title;
					this.tank = tank;
					this.amountOfFuelMixture = amountOfFuelMixture;
				}
				public static Car GetCar( String title, Engine engine, Tank tank = null, double fuelmixtureamount = 0.01 ) {
					if( tank == null )
						tank = new Tank(60);
					return new Car(engine, title, tank, fuelmixtureamount);
				}
				override public void TurnTheKey() {
					engine.Start();
				}
				override public void TurnOffTheKey() {
					engine.ShutOff();
				}
				override public void Gas() {
					engine.Work(
						tank.GetCurrentFuel(),
						ref tank.Drain(amountOfFuelMixture)
					);
				}
				override public void Brake() {

				}
			}
		}
	}
}
