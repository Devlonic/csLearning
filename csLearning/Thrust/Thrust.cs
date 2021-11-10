using System;

namespace Thrust {
	using energy;
	abstract class Thrust {
		protected Int32 chanceToStart = 0;
		protected Energy energyType = null;
		protected Double efficiency = 0;
		protected String title = "";
		protected void SetChanceToStart( Int32 c ) {
			chanceToStart = c;
		}
		protected void SetEnergyType( Energy c ) {
			energyType = c;
		}
		protected void SetEfficiency( Double c ) {
			efficiency = c;
		}
		protected void SetTitle( String c ) {
			title = c;
		}
		protected Thrust( int chanceToStart, Energy energyType, double efficiency, string title ) {
			this.chanceToStart = chanceToStart;
			this.energyType = energyType;
			this.efficiency = efficiency;
			this.title = title;
		}
	}
}
