using iReading.API.Models;
using iReading.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace iReading.API.Controllers
{
    [Route("api")]
    public class ArticleController : Controller
    {
        private readonly ArticleDbContext _db;
        public ArticleController(ArticleDbContext db)
        {
            _db = db;
        }

        [HttpGet,Route("article")]
        public ArticleViewModel GetArticle()
        {
            //return new string[] { "value1", "value2" };
            var article = _db.Articles
                .Where(t => t.Status == 0 && t.IsDelete == 0)
                .Select(t => new ArticleViewModel
                {
                    Title = t.Title,
                    Author = t.Author,
                    Content = t.Details
                }).LastOrDefault();
            return article;
        }

        [HttpGet,Route("random")]
        public ArticleViewModel GetRandomArticle()
        {
            var article = _db.Articles
                .Where(t => t.Status == 0 && t.IsDelete == 0)
                .OrderBy(t => Guid.NewGuid())
                .Select(t => new ArticleViewModel
                {
                    Title = t.Title,
                    Author = t.Author,
                    Content = t.Details
                }).LastOrDefault();
            return article;
        }
    }
}
