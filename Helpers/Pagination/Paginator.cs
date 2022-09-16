﻿namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Helpers.Pagination;

public class Paginator<T> where T : class
{
    public string Search { get; private set; }
    public int PageIndex { get; private set; }
    public int PageSize { get; private set; }
    public int Total { get; private set; }
    public IEnumerable<T> Registers { get; private set; }

    public Paginator(IEnumerable<T> registers, int total, int pageIndex,
        int pageSize, string search)
    {
        Registers = registers;
        Total = total;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Search = search;
    }

    public int TotalPages
    {
        get
        {

            return (int)Math.Ceiling(Total / (double)PageSize);
        }
    }

    public bool HasPreviousPage
    {
        get
        {
            return (PageIndex > 1);
        }
    }

    public bool HasNextPage
    {
        get
        {
            return (PageIndex < TotalPages);
        }
    }
}