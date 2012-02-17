using System.Collections.Generic;

namespace Interpreter {

	public class Number : IExpression {

		private readonly int _number;

		public Number(int number) {
			this._number = number;
		}
	
		public int Interpret(Dictionary<string, IExpression> variables) {
			return this._number;
		}

	}
}