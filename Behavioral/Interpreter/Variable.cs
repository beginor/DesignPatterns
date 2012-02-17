using System.Collections.Generic;

namespace Interpreter {

	public class Variable : IExpression {

		private readonly string _name;

		public Variable(string name) {
			this._name = name;
		}

		public int Interpret(Dictionary<string, IExpression> variables) {
			if (string.IsNullOrEmpty(this._name)) {
				return 0;
			}
			return variables[this._name].Interpret(variables);
		}
	}
}