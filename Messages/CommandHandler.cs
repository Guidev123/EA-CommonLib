using FluentValidation;
using FluentValidation.Results;

namespace EA.CommonLib.Messages
{
    public abstract class CommandHandler
    {
        protected CommandHandler() => ValidationResult = new ValidationResult();
        protected ValidationResult ValidationResult { get; set; }
        protected void AddError(string message) => ValidationResult.Errors.Add(new ValidationFailure(string.Empty, message));
        protected ValidationResult ValidateEntity<TV, TE>(
            TV validation, TE entity) where TV
        : AbstractValidator<TE> where TE : class => validation.Validate(entity);
    }
}
