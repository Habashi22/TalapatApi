﻿using TalapatApis.DTOS;

namespace TalapatApis.Helper
{
    public class Pagination<T>
    {

        public Pagination(int pageIndex, int pageSize, IReadOnlyList<T> mappedProducts, int count)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Data = mappedProducts;
            Count = count;
        }

        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }

    }
}
