namespace BlogWeb.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }

        public Blog(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription, string body)
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Body = body;
            IsDeleted = false;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
