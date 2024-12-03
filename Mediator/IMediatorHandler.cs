using EA.CommonLib.Messages;
using EA.CommonLib.Responses;
using FluentValidation.Results;

namespace EA.CommonLib.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T events) where T : Event;
        Task<Response<T>> SendCommand<T>(T command) where T : Command<T>;
    }
}
