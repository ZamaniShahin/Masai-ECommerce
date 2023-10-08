using System.Collections.Generic;
using System.Linq;
using _01_MasaiQuery.Contracts.Product;
using _01_MasaiQuery.Contracts.ProductCategory;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Infrastructure.EFCore;
using _0_Framework.Application;
using System;
using DiscountManagement.Infrastructure.EFCore;

namespace _01_MasaiQuery.Query
{
    public class ProductCategoryQuery : IProductCategoryQuery
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;

        public ProductCategoryQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }

        public ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug)
        {
            var inventory = _inventoryContext.Inventory.Select(x => new { x.ProductId, x.UnitPrice }).ToList();
            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId, x.EndDate }).ToList();

            var category = _context.ProductCategories
                .Include(x => x.Products)
                .ThenInclude(x => x.Category)
                .Select(x => new ProductCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Slug = x.Slug,
                    Products = MapProducts(x.Products)
                }).FirstOrDefault(z => z.Slug == slug);

            foreach (var product in category.Products)
            {
                var productInventory = inventory.FirstOrDefault(x => x.ProductId == product.Id);
                if (productInventory != null)
                {
                    var price = inventory
                        .FirstOrDefault(x => x.ProductId == product.Id)?.UnitPrice;
                    product.Price = price.ToString().ToMoney();
                    var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                    if (discount != null)
                    {
                        int discountRate = discount.DiscountRate;
                        product.DiscountRate = discountRate;
                        product.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                        product.HasDiscount = discountRate > 0;
                        var discountAmount = Math.Round((double)((price * discountRate) / 100));
                        product.PriceWithDiscount = (price - discountAmount).ToString().ToMoney();
                    }
                }
            }

            return category;
        }

        public List<ProductCategoryQueryModel> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new ProductCategoryQueryModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug
            }).ToList();
        }
        public List<ProductCategoryQueryModel> GetProducts()
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.ProductId, x.UnitPrice })
                .ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.DiscountRate, x.ProductId }).ToList();

            var categories = _context.ProductCategories
                .Include(x => x.Products)
                .ThenInclude(x => x.Category)
                .Select(x => new ProductCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Products = MapProducts(x.Products)
                }).ToList();

            foreach (var category in categories)
            {
                if (category.Products == null)
                {

                }
                else
                {
                    foreach (var product in category.Products)
                    {
                        var price = inventory
                            .FirstOrDefault(x => x.ProductId == product.Id)?.UnitPrice;
                        product.Price = price.ToString().ToMoney();

                        var discountRate = discounts.FirstOrDefault(x => x.ProductId == product.Id)?
                            .DiscountRate;
                        product.DiscountRate = Convert.ToInt32(discountRate);
                        product.HasDiscount = discountRate > 0;
                        if (discountRate == null)
                        {
                            discountRate = 0;
                        }
                        var discountAmount = Math.Round((double)((price * discountRate) / 100));
                        product.PriceWithDiscount = (price - discountAmount).ToString().ToMoney();
                    }
                }
            }

            return categories;
        }

        private static List<ProductQueryModel> MapProducts(List<Product> products)
        {
            return products.Select(product => new ProductQueryModel
            {
                Id = product.Id,
                Name = product.Name,
                Picture = product.Picture,
                PictureAlt = product.PictureAlt,
                PictureTitle = product.PictureTitle,
                Slug = product.Slug
            }).ToList();

        }
    }
}