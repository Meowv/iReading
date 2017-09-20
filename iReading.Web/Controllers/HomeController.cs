using iReading.DAL;
using iReading.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace iReading.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticleDbContext _db;

        public HomeController(ArticleDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var article = _db.Articles
                .Where(t => t.Status == 0 && t.IsDelete == 0)
                .Select(t => new ArticleViewModel
                {
                    Title = t.Title,
                    Author = t.Author,
                    Content = t.Details
                })
                .LastOrDefault();

            return View(article);
        }
    }
}