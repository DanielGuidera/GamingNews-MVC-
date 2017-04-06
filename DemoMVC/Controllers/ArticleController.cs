using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;
using DemoMVC.Data_Access_Layer;

namespace DemoMVC.Controllers
{
    public class ArticleController : Controller
    {        
        // GET: Article
        public ActionResult Read()
        {
            
            return View("Article");
        }

        public ActionResult Report()
        {
            return View();
        }
    }
}