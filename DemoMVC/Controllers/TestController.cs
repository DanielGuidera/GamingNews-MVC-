using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class TestController: Controller
    {
        private TechItem itemList;
        public ActionResult Test()
        {
            itemList = new TechItem();
            return View();
        }

        [HttpPost]
        public ActionResult Test(string userData)
        {
            itemList.AddToList(userData);
            ViewBag.Message = "Added: " + userData + "";
            return View();
        }

        public ActionResult List()
        {
            return View(itemList.GetItems());
        }
    }
}