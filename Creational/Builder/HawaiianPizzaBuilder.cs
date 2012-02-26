namespace Builder {

	class HawaiianPizzaBuilder : PizzaBuilder {

		public override void BuildDough() {
			this.Pizza.Dough = "cross";
		}

		public override void BuildSauce() {
			this.Pizza.Sauce = "mild";
		}

		public override void BuildTopping() {
			this.Pizza.Topping = "ham+pineapple";
		}
	}
}