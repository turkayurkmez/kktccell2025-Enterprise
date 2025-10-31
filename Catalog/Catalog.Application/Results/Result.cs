using Catalog.Application.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Results
{
    public class Result
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }       


    }

    public class ProductsResponseResult : Result
    {
        public IEnumerable<ProductSummaryResponse> Products { get; set; }
        public int TotalCount { get => Products.Count(); }

    }
}
