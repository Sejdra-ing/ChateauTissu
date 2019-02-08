using System.Collections.Generic;
using System.Web.Mvc;
using ChateauTissu.Models;
using ChateauTissu.Services;
using System.Web.Http;

namespace ChateauTissu.Controllers
{
    [Route("api/article")]
    public class ArticlesController : ApiController
    {
        private readonly ArticleService _articleService;
        public ArticlesController()
        {
            _articleService = new ArticleService();
        }

        public ArticlesController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET api/values
        public IEnumerable<Article> Get()
        {
            return _articleService.Get();
        }

        // GET api/values/5
        public Article Get(string id)
        {
            return _articleService.Get(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
