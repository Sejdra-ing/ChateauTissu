using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using ChateauTissu.Models;
using ChateauTissu.Services;

namespace ChateauTissu.Controllers
{
    public class HomeController : Controller
    {
        public static List<Person> persons = new List<Person>();
        public static List<Article> articles = new List<Article>();

        public static ArticleService _articleService;

        static HomeController()
        {
            _articleService = new ArticleService();
            articles = _articleService.Get();

            persons.Add(new Person { PersonID = 1, Name = "John", BirthDate = new DateTime(1968, 6, 26) });
            persons.Add(new Person { PersonID = 2, Name = "Sara", BirthDate = new DateTime(1974, 9, 13) });
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult GetArticles([DataSourceRequest] DataSourceRequest dsRequest)
        {
            var result = articles.ToDataSourceResult(dsRequest);
            return Json(result);
        }

        public ActionResult UpdateArticle([DataSourceRequest] DataSourceRequest dsRequest, Article article)
        {
            if (article != null && ModelState.IsValid)
            {
                var toUpdate = articles.FirstOrDefault(p => p.Id == article.Id);
                TryUpdateModel(toUpdate);
                _articleService.Update(article.Id, article);
            }


            return Json(ModelState.ToDataSourceResult());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
