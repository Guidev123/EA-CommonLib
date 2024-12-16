using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.CommonLib.Specs.Validation
{
    public class Rule<T>(Specification<T> spec, string errorMessage)
    {
        private readonly Specification<T> _specificationSpec = spec;

        public string ErrorMessage { get; } = errorMessage;

        public bool Validate(T obj) => _specificationSpec.IsSatisfiedBy(obj);
    }
}
