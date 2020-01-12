using ECommerce.Entity;
using ECommerce.Models;
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
            var products = context.Products.Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 40 ? i.Name.Substring(0, 37) + "..." : i.Name,
                    Description = i.Description.Length > 40 ? i.Description.Substring(0, 37) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();

            return View(products);
        }
    }
}