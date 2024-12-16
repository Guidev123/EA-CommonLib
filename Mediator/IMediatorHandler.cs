using EA.CommonLib.Messages;
using EA.CommonLib.Responses;

namespace EA.CommonLib.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T events) where T : Event;
        Task<Response<T>> SendCommand<T>(T command) where T : Command<T>;
        Task<Response<Y>> SendQuery<T, Y>(T query) where T : Query<T, Y>;
    }
}
