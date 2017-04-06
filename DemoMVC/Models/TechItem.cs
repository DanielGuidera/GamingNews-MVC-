using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class TechItem
    {
        public string Name { get; set; }
        private List<TechItem> itemList = new List<TechItem>();

        public IEnumerable<TechItem> GetItems()
        {
            //return new List<TechItem>
            //{
            //    new TechItem { Name = "ASP.net" },
            //    new TechItem { Name = "ASP"},
            //    new TechItem { Name = "ASP.net core" }
            //};         

            return itemList;            
        }

        public void AddToList(string data)
        {
            itemList.Add(new TechItem { Name = data });            
        }
        
                
    }
}