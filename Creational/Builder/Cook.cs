namespace Builder {

	class Cook {

		private PizzaBuilder _pizzaBuilder;

		public void SetPizzaBuilder(PizzaBuilder pb) {
			this._pizzaBuilder = pb;
		}

		public Pizza GetPizza() {
			return this._pizzaBuilder.GetPizza();
		}

		public void ConstructPizza() {
			this._pizzaBuilder.CreateNewPizzaProduct();
			this._pizzaBuilder.BuildDough();
			this._pizzaBuilder.BuildSauce();
			this._pizzaBuilder.BuildTopping();
		}
	}
}