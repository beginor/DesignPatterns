using System.Collections.Generic;

namespace Interpreter {

	public class Evaluator : IExpression {

		private readonly IExpression _expressionTree;

		public Evaluator(string expression) {
			var stack = new Stack<IExpression>();
			foreach (var token in expression.Split(' ')) {
				if (token == "+") {
					stack.Push(new Plus(stack.Pop(), stack.Pop()));
				}
				else if (token == "-") {
					var right = stack.Pop();
					var left = stack.Pop();
					stack.Push(new Minus(left, right));
				}
				else {
					stack.Push(new Variable(token));
				}
			}
			this._expressionTree = stack.Pop();
		}
		
		public int Interpret(Dictionary<string, IExpression> context) {
			return this._expressionTree.Interpret(context);
		}
	}
}