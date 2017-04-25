﻿using System;
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
            ArticleModels articleData;

            ArticleAccess access = new ArticleAccess();
            if (access.GetArticleForRead(out articleData, _ID))
            {
                ViewData["ArticleInfo"] = articleData;
                return View("Article");
            }
            else
            {
                return View("Error");
            }            
        }

        public ActionResult Report()
        {
            return View();
        }        
    }
}