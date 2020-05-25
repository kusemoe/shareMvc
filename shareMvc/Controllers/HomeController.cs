using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace shareMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int limit = 6, int page = 1)
        {
            var list = new List<article>
            {
                new article{ArticleId=1,UserId=1,ArticleName="标题1",Comment=11000,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=12000,like=1000,ReleaseDateTime=DateTime.Now,view=10000},
                new article{ArticleId=1,UserId=1,ArticleName="标题2",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题3",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题4",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题5",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题6",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题7",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题8",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1},
                new article{ArticleId=1,UserId=1,ArticleName="标题9",Comment=1,Content="缘起最近经常有伙伴问我，作为程序员，有没有好的画图工具推荐，领导说Microsoft Visio画图工具很强，让我们使",Favorite=1,like=1,ReleaseDateTime=DateTime.Now,view=1}
            };
            var total = list.Count % limit != 0 ? (list.Count / limit) + 1 : list.Count / limit;
            ViewBag.page = page;
            ViewBag.total = total;
            ViewBag.ListCount = list.Count;
            var Paging = list.Skip((page - 1) * limit)
                             .Take(limit)
                             .ToList();
            return View(Paging);
        }

        public ActionResult SelectArticle()
        {
            return View(new ArticleBll().SelectArticle());
        }
    }
}
