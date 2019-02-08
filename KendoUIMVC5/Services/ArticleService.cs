using KendoUIMVC5.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVC5.Services
{

    public class ArticleService
    {
        private readonly IMongoCollection<Article> _article;


        public ArticleService()
        {

            var MongoClient = new MongoClient("mongodb://localhost:27017");

            var database = MongoClient.GetDatabase("ArticlestoreDb");
            _article = database.GetCollection<Article>("Articles");
        }

        public List<Article> Get()
        {
            return _article.Find(article => true).ToList();
        }

        public Article Get(string id)
        {
            return _article.Find<Article>(article => article.Id == id).FirstOrDefault();
        }

        public Article Create(Article article)
        {
            _article.InsertOne(article);
            return article;
        }

        public void Update(string id, Article articleIn)
        {
            _article.ReplaceOne(article => article.Id == id, articleIn);
        }

        public void Remove(Article articleIn)
        {
            _article.DeleteOne(article => article.Id == articleIn.Id);
        }

        public void Remove(string id)
        {
            _article.DeleteOne(article => article.Id == id);
        }

    }
}