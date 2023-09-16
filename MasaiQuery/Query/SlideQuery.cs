using System.Collections.Generic;
using System.Linq;
using _01_MasaiQuery.Contracts.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_MasaiQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _shopContext;

        public SlideQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _shopContext.Slides.Where(x => x.IsRemoved == false)
                .Select(x => new SlideQueryModel
                {
                    Picture = x.Picture,
                    PictureTitle = x.PictureTitle,
                    PictureAlt = x.PictureAlt,
                    BtnText = x.BtnText,
                    Heading = x.Heading,
                    Link = x.Link,
                    Text = x.Text,
                    Title = x.Title,
                }).ToList();
        }
    }
}