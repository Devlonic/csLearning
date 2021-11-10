namespace transport {
	abstract class Transport {
		protected abstract void On();
		protected abstract void Off();
		protected abstract void Move();
		protected abstract void Stop();
	}
}
