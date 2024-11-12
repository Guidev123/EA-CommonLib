using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EA.CommonLib.MessageBus
{
    public static class DependencyInjectionExtensions
    {
        public static void AddMessageBus(this IServiceCollection services, string connection)
        {
            if (string.IsNullOrEmpty(connection)) throw new();

            services.AddSingleton<IMessageBus>(new MessageBus(connection));
        }

        public static string GetMessageQueueConnection(this IConfiguration configuration, string name) =>
            configuration?.GetSection("MessageQueueConnection")?[name] ?? string.Empty;
    }
}
