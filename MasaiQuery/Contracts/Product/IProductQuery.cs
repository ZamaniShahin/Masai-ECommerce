using System.Collections.Generic;

namespace _01_MasaiQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetDetails(string slug);
        List<ProductQueryModel> Search(string value);
    }
}