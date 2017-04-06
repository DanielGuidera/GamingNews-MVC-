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
        public ActionResult Read(int _ID)
        {            
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ArticleContext"].ToString();
            //LinqToSQLDataContext db = new LinqToSQLDataContext(connectionString);                       

            //ViewData["ArticleInfo"] = from myRow in db.GetTable<ArticleModels>() where myRow.ID.Equals(_ID) select myRow;
            return View("Article");
        }

        public ActionResult Report()
        {
            return View();
        }
    }
}