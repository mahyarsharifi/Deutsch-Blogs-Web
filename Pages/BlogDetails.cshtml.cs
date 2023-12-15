using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.Xml;

namespace BlogWeb.Pages
{
    public class BlogDetailsModel : PageModel
    {
        private readonly BlogContext _context;
        public BlogViewModel Blog;
        public BlogDetailsModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Blog = _context.Blogs.Select(x => new BlogViewModel
            {
                Id = x.Id,
                Body = x.Body,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
