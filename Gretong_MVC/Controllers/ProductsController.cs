using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gretong_MVC.Controllers
{
    public class ProductsController : Controller
    {

        ShoppingCartEntities db = new ShoppingCartEntities();

        // GET: Products
        public ActionResult Index(int categoryid = 0)
        {
            var products = new List<Product>();

            if (categoryid > 0)
                products = db.Products.Where(c => c.Id == categoryid).ToList();
            else
                products = db.Products.ToList();

            return View(products);
        }
    }
}