﻿namespace CarImport.Infrastructure.Helpers
{
    public class PaginatedData<T> {
        public int TotalItems { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public List<T> Items { get; set; } }
}
