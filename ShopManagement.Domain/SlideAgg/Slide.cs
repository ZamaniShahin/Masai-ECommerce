﻿using _0_Framework.Domain;

namespace ShopManagement.Domain.SlideAgg
{
    public class Slide :EntityBase
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
        public string Link { get; private set; }

        public Slide(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string btnText, string creationDate, string link)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
            IsRemoved = false;
            Link = link;
        }
        public void Edit(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string btnText,string link)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
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