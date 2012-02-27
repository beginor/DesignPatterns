using System.Collections.Generic;

namespace FactoryMethod {
	
	abstract class MazeGame {

		private readonly IList<Room> _rooms = new List<Room>();
		
		protected MazeGame() {
			var room1 = this.MakeRoom();
			var room2 = this.MakeRoom();
			room1.Connect(room2);
			this.AddRoom(room1);
			this.AddRoom(room2);
		}

		private void AddRoom(Room room) {
			this._rooms.Add(room);
		}

		protected abstract Room MakeRoom();

	}
}