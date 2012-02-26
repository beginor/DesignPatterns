namespace Builder {

	class Program {

		static void Main(string[] args) {
			PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
			var cook = new Cook();
			cook.SetPizzaBuilder(hawaiianPizzaBuilder);
			cook.ConstructPizza();
			// create the product
			var hawaiian = cook.GetPizza();

			PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
			cook.SetPizzaBuilder(spicyPizzaBuilder);
			cook.ConstructPizza();
			// create another product
			var spicy = cook.GetPizza();
		}

	}

}
