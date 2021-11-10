using System;

namespace Thrust {
	namespace state {
		class Message : Exception {
			public Message( String contextTitle, String message ) : base(contextTitle + "\t:\t" + message) { }
		}
	}
}
