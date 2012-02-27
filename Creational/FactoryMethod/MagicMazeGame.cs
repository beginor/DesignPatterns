namespace FactoryMethod {
	
	class MagicMazeGame : MazeGame {

		protected override Room MakeRoom() {
			return new MagicRoom();
		}
	}
}