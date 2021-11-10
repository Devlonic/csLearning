// todo

using energy;

namespace Thrust {
	namespace electric {
		class Electric : Thrust {
			public Electric( int chanceToStart, Energy energyType, double efficiency, string title ) 
				: base(chanceToStart, energyType, efficiency, title) {
			}
		}
	}
}
