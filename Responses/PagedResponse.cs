using System.Text.Json.Serialization;

namespace EA.CommonLib.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        public const int DEFAULT_PAGE_SIZE = 5;
        public const int DEFAULT_PAGE_NUMBER = 1;

        [JsonConstructor]
        public PagedResponse(
            TData? data,
            int totalCount,
            int currentPage = DEFAULT_PAGE_NUMBER,
            int pageSize = DEFAULT_PAGE_SIZE)
            : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(
        TData? data,
            int code = DEFAULT_STATUS_CODE,
            string? message = null)
            : base(data, code, message)
        {
        }

        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = DEFAULT_PAGE_SIZE;
        public int TotalCount { get; set; }
    }
}
