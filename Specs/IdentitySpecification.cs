using System.Linq.Expressions;

namespace EA.CommonLib.Specs
{
    internal sealed class IdentitySpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression() => x => true;
    }
}
