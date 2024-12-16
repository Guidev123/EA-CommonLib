using MediatR;
using FluentValidation.Results;
using EA.CommonLib.Responses;
using System.Text.Json.Serialization;

namespace EA.CommonLib.Messages
{
    public abstract class Command<T> : Message, IRequest<Response<T>>
    {
        public DateTime Timestamp { get; private set; }
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();
        protected Command() => Timestamp = DateTime.Now;

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
