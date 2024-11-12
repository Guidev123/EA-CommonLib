using Polly;
using Polly.Extensions.Http;
using Polly.Retry;

namespace EA.CommonLib.Extensions
{
    public static class PollyExtensions
    {
        public static AsyncRetryPolicy<HttpResponseMessage> AwaitTry()
        {
            var retry = HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(
                [
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10),
                ], (outcome, timespan, retryCount, context) =>
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Try: {retryCount}x times");
                    Console.ForegroundColor = ConsoleColor.White;
                });

            return retry;
        }
    }
}
