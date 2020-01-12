using ECommerce.Entity;
using ECommerce.Models;
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

        public ActionResult List(int? id)
        {
            var products = context.Products.Where(i => i.IsApproved)
                   .Select(i => new ProductModel()
                   {
                       Id = i.Id,
                       Name = i.Name.Length > 40 ? i.Name.Substring(0, 37) + "..." : i.Name,
                       Description = i.Description.Length > 40 ? i.Description.Substring(0, 37) + "..." : i.Description,
                       Price = i.Price,
                       Stock = i.Stock,
                       Image = i.Image ?? "1.jpg",
                       CategoryId = i.CategoryId
                   }).AsQueryable();

            if (id !=null)
            {
                products = products.Where(i=>i.CategoryId==id);
            }

            return View(products.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(context.Categories.ToList());
        }


        public ActionResult Detail(int id)
        {
            return View(context.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
    }
}