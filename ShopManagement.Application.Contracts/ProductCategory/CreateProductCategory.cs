using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }
        public string Description { get; set; }
        [MaxFileSize(3 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        [FileExtensionLimitation(new string[] { ".jpeg", ".png", ".jpg" },
            ErrorMessage = ValidationMessages.InvalidFileFormat)]
        public IFormFile Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }
    }
}
