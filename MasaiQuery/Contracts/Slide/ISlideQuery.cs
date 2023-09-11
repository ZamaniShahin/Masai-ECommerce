using System.Collections.Generic;

namespace _01_MasaiQuery.Contracts.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();

    }
}