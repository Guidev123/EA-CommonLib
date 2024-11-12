using EA.CommonLib.Messages;
using FluentValidation.Results;

namespace EA.CommonLib.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T events) where T : Event;

        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
