using System.Collections.Generic;

namespace _01_MasaiQuery.Contracts.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> Search(string value);
    }
}