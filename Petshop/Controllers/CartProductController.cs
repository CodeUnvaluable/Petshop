using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petshop.Controllers
{
    public class CartProductController : Controller
    {
        // GET: CartProduct
        public ActionResult Index()
        {
            return View();
        }
    }
}