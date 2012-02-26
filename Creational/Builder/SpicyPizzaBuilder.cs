namespace Builder {

	class SpicyPizzaBuilder : PizzaBuilder {

		public override void BuildDough() {
			this.Pizza.Dough = "pan baked";
		}

		public override void BuildSauce() {
			this.Pizza.Sauce = "hot";
		}

		public override void BuildTopping() {
			this.Pizza.Topping = "pepperoni + salami";
		}
	}
}