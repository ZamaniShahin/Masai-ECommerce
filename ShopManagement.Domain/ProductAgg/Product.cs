using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManagement.Domain.ProductAgg
{
    public class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public long CategoryId { get; private set; }
        public string Slug { get; private set; }
        public ProductCategory Category { get; private set; }
        public List<ProductPicture> ProductPictures { get; private set; }

        public Product(string name, string description, string picture, string pictureAlt,
            string pictureTitle, long categoryId, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
        }
        public void Edit(string name,
            string description, string picture, string pictureAlt,
            string pictureTitle, long categoryId, string slug)
        {
            Name = name;
            Description = description;
            if (!string.IsNullOrWhiteSpace(Picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CategoryId = categoryId;
            Slug = slug;
        }
    }
}
