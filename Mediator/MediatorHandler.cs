using EA.CommonLib.Messages;
using FluentValidation.Results;
using MediatR;

namespace EA.CommonLib.Mediator
{
    public class MediatorHandler(IMediator mediator) : IMediatorHandler
    {
        private readonly IMediator _mediator = mediator;
        public async Task<ValidationResult> SendCommand<T>(T command) where T : Command => await _mediator.Send(command);
        public async Task PublishEvent<T>(T events) where T : Event => await _mediator.Publish(events);
    }
}
