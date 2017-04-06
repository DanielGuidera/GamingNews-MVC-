using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DemoMVC.Models;

namespace DemoMVC.Data_Access_Layer
{
    public class ArticleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            var articles = new List<ArticleModels>
            {
                new ArticleModels {ID = 1, title = "God of War", thumbnail = "https://i.ytimg.com/vi/CJ_GCPaKywg/maxresdefault.jpg" },
                new ArticleModels {ID = 2, title = "The Last of Us", thumbnail = "https://c2.staticflickr.com/6/5597/31396458265_93118cec4a_z.jpg" },
                new ArticleModels {ID = 3, title = "Shadow of War", thumbnail = "https://cdn.gamerant.com/wp-content/uploads/middle-earth-shadow-of-war-mithril-edition-title.jpg" },
                new ArticleModels {ID = 4, title = "Persona 5", thumbnail = "http://vignette4.wikia.nocookie.net/megamitensei/images/6/68/P5_illustration_by_Shigenori_Soejima.jpg/revision/latest?cb=20150919150530" },
                new ArticleModels {ID = 5, title = "Horizon Zero Dawn", thumbnail = "https://i.ytimg.com/vi/GauAr4lWjyw/maxresdefault.jpg" }
            };

            articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();
        }
    }
}