using System.Collections.Generic;

namespace Interpreter {

	public interface IExpression {

		int Interpret(Dictionary<string, IExpression> context);

	}
}