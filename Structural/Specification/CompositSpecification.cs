using System;
using Specification;

namespace Specification {

    public abstract class CompositSpecification<TTarget> : ISpecification<TTarget> {

        public abstract bool IsSatisfiedBy(TTarget candidate);

        public ISpecification<TTarget> And(ISpecification<TTarget> specification) {
            return new AndSpecification<TTarget>(this, specification);
        }

        public ISpecification<TTarget> Or(ISpecification<TTarget> specification) {
            return new OrSpecification<TTarget>(this, specification);
        }

        public ISpecification<TTarget> Not(ISpecification<TTarget> specification) {
            return new NotSpecification<TTarget>(specification);
        }

    }

}
