using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.CommonLib.MessageBus.Integration.DeleteCustomer
{
    public class DeleteCustomerIntegrationEvent : IntegrationEvent
    {
        public DeleteCustomerIntegrationEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; private set; }
    }
}
