namespace Thrust {
	using energy;
	namespace Ice {
		abstract class Ice : Thrust {
			protected Ice( int chanceToStart, Energy energyType, double efficiency, string title ) : 
				base(chanceToStart, energyType, efficiency, title) 
				{
			}
		}
	}
}
