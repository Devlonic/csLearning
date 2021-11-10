using System;

namespace Thrust {
	using energy;
	namespace state {
		abstract class State {
			protected Thrust context;
			public void SetContext( Thrust context ) {
				this.context = context;
			}
			public abstract Double Work( Energy fuel, ref Double count );
			public abstract void Start();
			public abstract void ShutOff();
		}
	}
}
