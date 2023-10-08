using System.Collections.Generic;
using _01_MasaiQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductCategoryModel : PageModel
    {
        public ProductCategoryQueryModel ProductCategory { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }

        private readonly IProductCategoryQuery _productCategoryQuery;

        public ProductCategoryModel(IProductCategoryQuery productCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
        }

        public void OnGet(string id)
        {
            ProductCategory = _productCategoryQuery.GetProductCategoryWithProductsBy(id);
            ProductCategories = _productCategoryQuery.GetProductCategories();
        }
    }
}
