namespace ShopManagement.Domain.SlideAgg
{
    public class Slide
    {
        public long Id { get; set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Heading { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string BtnText { get; set; }
        public bool IsRemoved { get; private set; }
        public string CreationDate { get; set; }

        public Slide(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string btnText, string creationDate)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
            IsRemoved = false;
            CreationDate = creationDate;
        }
        public void Edit(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string btnText)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}