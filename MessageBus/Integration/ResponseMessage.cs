using EA.CommonLib.Messages;
using FluentValidation.Results;

namespace EA.CommonLib.MessageBus.Integration
{
    public class ResponseMessage : Message
    {
        public ResponseMessage(ValidationResult validationResult) => ValidationResult = validationResult;
        public ValidationResult ValidationResult { get; set; }
    }
}
