using System;
using Specification;

namespace Specification {

    public class NotSpecification<TTarget> : CompositSpecification<TTarget> {

        readonly ISpecification<TTarget> x;

        public NotSpecification(ISpecification<TTarget> x) {
            this.x = x;
        }

        public override bool IsSatisfiedBy(TTarget candidate) {
            return !x.IsSatisfiedBy(candidate);
        }

    }

}
