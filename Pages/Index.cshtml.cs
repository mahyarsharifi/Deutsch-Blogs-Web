using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogContext _context;
        public List<BlogViewModel> Blogs;
        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Blogs = _context.Blogs.Where(x => x.IsDeleted == false).Select(x => new BlogViewModel
            {
                Id = x.Id,
                Body = x.Body,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription
            }).OrderByDescending(x => x.Id).ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            blog.Delete();
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}