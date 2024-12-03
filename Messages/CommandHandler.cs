using FluentValidation;
using FluentValidation.Results;

namespace EA.CommonLib.Messages
{
    public abstract class CommandHandler
    {
        protected void AddError(ValidationResult validationResult, string message) =>
            validationResult.Errors.Add(new ValidationFailure(string.Empty, message));

        protected string GetAllErrors(ValidationResult validationResult) =>
            string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));

        protected ValidationResult ValidateEntity<TV, TE>(
            TV validation, TE entity) where TV
        : AbstractValidator<TE> where TE : class => validation.Validate(entity);
    }
}
