using System;
using System.Text.Json;
using API.Helpers;
using Microsoft.AspNetCore.Http.Json;

namespace API.Extensions;

public static class HTTPExtensions
{
    public static void AddPaginationHeader<T>(this HttpResponse response, PageList<T> data)
    {
        var paginationHeader = new PagginationHeader(data.CurrentPage, data.PageSize, data.TotalCount, data.TotalPages);

        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        response.Headers.Append("Pagination", JsonSerializer.Serialize(paginationHeader, jsonOptions));
        response.Headers.Append("Access-Control-Expose-Headers", "Pagination");
    }
}
