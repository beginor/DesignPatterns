using System.Collections.Generic;

namespace Interpreter {

	public class Plus : IExpression {

		private readonly IExpression _leftOperand;
		private readonly IExpression _rightOperand;

		public Plus(IExpression leftOperand, IExpression rightOperand) {
			this._leftOperand = leftOperand;
			this._rightOperand = rightOperand;
		}

		public int Interpret(Dictionary<string, IExpression> context) {
			return this._leftOperand.Interpret(context) + this._rightOperand.Interpret(context);
		}

	}
}