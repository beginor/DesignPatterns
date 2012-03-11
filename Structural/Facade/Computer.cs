namespace Facade {

	class Computer {

		private readonly Cpu _cpu;
		private readonly Memory _memory;
		private readonly HardDrive _hardDrive;

		private const long BootAddress = 0;

		public Computer() {
			this._cpu = new Cpu();
			this._memory = new Memory();
			this._hardDrive = new HardDrive();
		}

		public void StartComputer() {
			this._cpu.Freeze();
			this._memory.Load(BootAddress, this._hardDrive.Read(BootAddress));
			this._cpu.Execute();
		}
	}
}