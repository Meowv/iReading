using Reading.Bll;
using System.Web.Mvc;

namespace Reading.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticleBll _bll = new ArticleBll();

        public ActionResult Index()
        {
            //var article = _bll.Get_Articles_List()
            //    .Select(a => new Articles
            //    {
            //        Title = a.Title,
            //        Author = a.Author,
            //        Content = a.Content
            //    }).LastOrDefault();

            var article = _bll.Get_New_Article();

            return View(article);
        }
    }
}