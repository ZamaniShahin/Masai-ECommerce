namespace _01_MasaiQuery.Contracts.Product
{
    public class ProductPictureQueryModel
    {
        public long PictureId { get; set; }
        public string Picture { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }
        public bool IsRemoved { get; set; }
    }
}