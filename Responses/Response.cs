using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EA.CommonLib.Responses
{
    public class Response<TData>
    {
        public Response(
            TData? data,
            int code = 200,
            string? message = null,
            string[]? errors = null)
        {
            Data = data;
            Message = message;
            Code = code;
            Errors = errors;
        }

        [JsonIgnore]
        public int Code { get; }
        public TData? Data { get; }
        public string? Message { get; }
        public string[]? Errors { get; }

        [JsonIgnore]
        public bool IsSuccess
            => Code is >= 200 and <= 299;
    }
}
