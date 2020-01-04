using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {

        DataContext context = new DataContext();
        // GET: Homehey
        public ActionResult Index()
        {

            return View(context.Products.Where(i=>i.IsHome&&i.IsApproved).ToList());
        }
    }
}