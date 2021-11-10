namespace transport {
	namespace land {
		abstract class Land : Transport {
			override protected abstract void Move();
			override protected abstract void Off();
			override protected abstract void On();
			override protected abstract void Stop();
		}
	}
}
