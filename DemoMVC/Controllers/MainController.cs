using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using DemoMVC.Data_Access_Layer;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private ArticleAccess access = new ArticleAccess();
        public ActionResult HomePage(ArticleModels.Status status = ArticleModels.Status.Approved)
        {           
            ViewData["ArticleList"] = access.retrieveArticles(status);
            return View();
        }       
    }
}