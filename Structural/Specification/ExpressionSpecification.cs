using System;

namespace Specification {

    public class ExpressionSpecification<TTarget> : CompositSpecification<TTarget> {

        readonly Func<TTarget, bool> expression;

        public ExpressionSpecification(Func<TTarget, bool> expression) {
            this.expression = expression;
        }

        public override bool IsSatisfiedBy(TTarget candidate) {
            return expression(candidate);
        }

    }
}

