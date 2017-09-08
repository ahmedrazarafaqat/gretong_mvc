using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gretong_MVC.Controllers
{
    public class CategoryController : Controller
    {
        ShoppingCartEntities db = new ShoppingCartEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategories()
        {

            var categories = db.Categories.ToList();
            return PartialView(categories);
        }
    }
}