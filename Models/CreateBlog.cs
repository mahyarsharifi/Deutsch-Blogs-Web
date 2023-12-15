using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class CreateBlog
    {
        [Required(ErrorMessage = "Das Feld Ist Erforderlich.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Das Feld Ist Erforderlich.")]
        public string Picture { get; set; }

        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "Das Feld Ist Erforderlich.")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Das Feld Ist Erforderlich.")]
        public string Body { get; set; }

        public CreateBlog()
        {
        }

        public CreateBlog(string title, string picture, string pictureAlt, string pictureTitle, string shortDescription, string body)
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Body = body;
        }
    }
}
