using System;

namespace entry {
	class Program {
		private static int Main() {
			const Int32 countPistons = 4;
			const Double cylinderVolume = 392.25;
			const Double cylinderDiameter = 78.93;
			const Double efficicency = 22.4;
			const String title = "Engine.VAZ2106";
			Fuel fuel = new Petrol();
			Engine engine = Engine.GetEngine(
					countPistons,
					cylinderVolume,
					cylinderDiameter,
					fuel,
					efficicency,
					title,
					20 // chance to start
			);

			Tank tank = new Tank(100);
			tank.Fill(new Petrol(), 120);
			Random random = new Random(DateTime.Now.Millisecond);
			while( !tank.isEmpty() ) {
				try {
					if( Console.KeyAvailable )
						switch( Console.ReadKey(true).Key ) {
							case ConsoleKey.Enter:
							engine.Start();
							break;

							case ConsoleKey.Spacebar:
							engine.ShutOff();
							break;

							case ConsoleKey.G:
								Console.WriteLine(
									"Usefull energy produced:\t{0}\t J",
									engine.Work(tank.GetCurrentFuel(), ref tank.Drain(0.01)) * 1000
								);
							break;
						}

				} catch( Exception e ) {
					Console.WriteLine("LOG: {0}", e.Message);
				}
			}
			
			return 0;
		}    
    }
}