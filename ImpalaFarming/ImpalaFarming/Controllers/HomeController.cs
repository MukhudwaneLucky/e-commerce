using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImpalaFarming.Models;

namespace ImpalaFarming.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            /*
            ViewBag.Error = "Database Successfull";
            
                try
                {
                    //testing database
                    using (var db = new ImpalaFarmingDB())
                    {
                        //[C]reate
                        ViewBag.Insert = "Inserting to Database";
                        db.Add(new Product
                        {
                            name = "Product Name DB Test 1",
                            available_in_stock = 10,
                            price = 159.99
                        });
                        db.SaveChanges();
                        ViewBag.InsertDone = "Saved New Product Successfully";

                        //[R]ead
                        ViewBag.Read = "Read From Database";
                        var product = db.Products.OrderBy(b => b.id).FirstOrDefault();
                        ViewBag.ReadDetails = "Product Name : " + product.name + " And Price : R" + product.price;
                        ViewBag.ReadDone = "Read From Database Succesfully";

                        //[U]pdate
                        ViewBag.Update = "Update from database";
                        product.price = 129.99;
                        product.available_in_stock = 9;
                        ViewBag.UpdateDetails = "Product Name : " + product.name + " And Price : R" + product.price;
                        ViewBag.UpdateDone = "Update From Database Succesfully";

                        //[D]elete
                        ViewBag.Delete = "Delete from database";
                        db.Remove(product);
                        db.SaveChanges();
                        ViewBag.DeleteDone = "deleted successfully";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Error = "Base :" + ex.GetBaseException() +
                        "Inner :" + ex.InnerException +
                        "All : " + ex.Message;
                }
            */
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
