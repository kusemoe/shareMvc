using Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace DAL
{
    public class ArticleDal
    {
        readonly shareEntities share = new shareEntities();
        public List<article> SelectArticle() => share.article.ToList();
        public article SelectArticle(int ArticleId) => share.article.Find(ArticleId);
        public List<article> SelectArticleByUserId(int UserId) => share.article.Where(i => i.UserId == UserId).ToList();
        public bool AddArticle(article ar)
        {
            share.article.Add(ar);
            return share.SaveChanges() > 0;
        }
        public bool DelArticle(int id)
        {
            share.article.Remove(share.article.Find(id));
            return share.SaveChanges() > 0;
        }
        public bool UpdateArticle(article ar)
        {
            share.Set<article>().Attach(ar);
            share.Entry(ar).State = EntityState.Modified;
            return share.SaveChanges() > 0;
        }
    }
}
