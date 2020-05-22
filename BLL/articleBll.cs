using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
    public class ArticleBll
    {
        readonly ArticleDal article = new ArticleDal();

        public bool DelArticle(int id) => article.DelArticle(id);

        public bool AddArticle(article ar) => article.AddArticle(ar);

        public List<article> SelectArticle() => article.SelectArticle();

        public bool UpdateArticle(article ar) => article.UpdateArticle(ar);

        public article SelectArticle(int ArticleId) => article.SelectArticle(ArticleId);

        public List<article> SelectArticleByUserId(int UserId) => article.SelectArticleByUserId(UserId);

    }
}