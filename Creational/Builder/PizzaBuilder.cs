namespace Builder {

	abstract class PizzaBuilder {

		protected Pizza Pizza;

		public Pizza GetPizza() {
			return this.Pizza;
		}

		public void CreateNewPizzaProduct() {
			this.Pizza = new Pizza();
		}

		public abstract void BuildDough();
		public abstract void BuildSauce();
		public abstract void BuildTopping();
	}
}