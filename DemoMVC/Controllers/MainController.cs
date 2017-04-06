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
        private ArticleContext db = new ArticleContext();

        public ActionResult HomePage()
        {            
            ViewData["ArticleList"] = db.Articles.ToList();
            return View();
        }
    }
}