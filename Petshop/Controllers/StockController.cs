using Petshop.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petshop.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            using(PetshopEntities1 dbContext = new PetshopEntities1())
            {
                dbContext.Product.Select(x => x).ToList();
            }
            return View();
        }
    }
}