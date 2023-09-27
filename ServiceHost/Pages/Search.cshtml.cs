using System.Collections.Generic;
using _01_MasaiQuery.Contracts.Product;
using _01_MasaiQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<ProductQueryModel> Products;
        public List<ProductCategoryQueryModel> ProductCategories;

        private readonly IProductQuery _productQuery;
        private readonly IProductCategoryQuery _productCategoryQuery;

        public SearchModel(IProductQuery productQuery, IProductCategoryQuery productCategoryQuery)
        {
            _productQuery = productQuery;
            _productCategoryQuery = productCategoryQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            Products = _productQuery.Search(value);
            ProductCategories = _productCategoryQuery.GetProductCategories();
        }
    }
}
