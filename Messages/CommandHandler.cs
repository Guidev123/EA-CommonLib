using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.CommonLib.Messages
{
    public abstract class CommandHandler
    {
        protected CommandHandler() => ValidationResult = new ValidationResult();
        protected ValidationResult ValidationResult { get; set; }
        protected void AddError(string mensagem) => ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
    }
}
