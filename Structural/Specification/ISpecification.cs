using System;
using Specification;

namespace Specification {

    public interface ISpecification<TTarget> {

        bool IsSatisfiedBy(TTarget candidate);

        ISpecification<TTarget> And(ISpecification<TTarget> specification);

        ISpecification<TTarget> Or(ISpecification<TTarget> specification);

        ISpecification<TTarget> Not(ISpecification<TTarget> specification);

    }

}
