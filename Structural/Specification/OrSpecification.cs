using System;
using Specification;

namespace Specification {

    public class OrSpecification<TTarget> : CompositSpecification<TTarget> {

        readonly ISpecification<TTarget> x;
        readonly ISpecification<TTarget> y;

        public OrSpecification(ISpecification<TTarget> x, ISpecification<TTarget> y) {
            this.x = x;
            this.y = y;
        }

        public override bool IsSatisfiedBy(TTarget candidate) {
            return x.IsSatisfiedBy(candidate) || y.IsSatisfiedBy(candidate);
        }

    }

}
