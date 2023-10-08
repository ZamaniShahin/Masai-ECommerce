using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [MaxFileSize(3 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        [FileExtensionLimitation(new string[] { ".jpeg", ".png", ".jpg" },
            ErrorMessage = ValidationMessages.InvalidFileFormat)]
        public IFormFile Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        [Range(1,100000,ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }
        public List<ProductCategoryViewModel> Categories { get; set; }
    }
}
