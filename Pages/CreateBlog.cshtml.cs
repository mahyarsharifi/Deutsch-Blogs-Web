using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogWeb.Pages
{
    public class CreateBlogModel : PageModel
    {
        private readonly BlogContext _context;
        public CreateBlog Command;

        [TempData]
        public string SuccesMessage { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }

        public CreateBlogModel(BlogContext context)
        {
            _context = context;
            Command = new CreateBlog();
        }

        public void OnGet()
        {
        }
        public void OnPost(CreateBlog command)
        {
            if (ModelState.IsValid)
            {
                var blog = new Blog(command.Title, command.Picture, command.PictureAlt, command.PictureTitle, command.ShortDescription, command.Body);
                _context.Blogs.Add(blog);
                _context.SaveChanges();

                SuccesMessage = "Der Blog Wurde Erfolgreich Erstellt .";
            }
            else
            {
                ErrorMessage = "Die Erstellung ِes Blogs Ist Ehlgeschlagen !";
            }
        }
    }
}
