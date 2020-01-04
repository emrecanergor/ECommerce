using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {

        DataContext context = new DataContext();

        public ActionResult List()
        {
            return View(context.Products.Where(i=>i.IsApproved).ToList());
        }

        public ActionResult Detail(int id)
        {
            return View(context.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
    }
}