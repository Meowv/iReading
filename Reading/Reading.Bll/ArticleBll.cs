using System.Collections.Generic;
using Reading.Dal;
using Reading.Model;

namespace Reading.Bll
{
    public class ArticleBll
    {
        private readonly ArticleDal _dal = new ArticleDal();

        public int InsertArticle(Articles articles) => _dal.InsertArticle(articles);

        public bool IsExistArticle(string author, string title) => _dal.IsExistArticle(author, title) >= 1;

        public IEnumerable<Articles> Get_Articles_List() => _dal.Get_Articles_List();

        public Articles Get_New_Article() => _dal.Get_New_Article();

        public Articles Get_Random_Article() => _dal.Get_Random_Article();
    }
}