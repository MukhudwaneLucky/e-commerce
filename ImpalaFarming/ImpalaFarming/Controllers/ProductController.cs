using System;
using ImpalaFarming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImpalaFarming.Controllers
{
    public class ProductController : Controller
    {
        public ImpalaFarmingDB db = new ImpalaFarmingDB();
        // GET: Product
        public ActionResult Shop()
        {
            return View(db.Products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(db.Products.Find(id));
        }

        // GET: Product/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product product)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Shop));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Products.Find(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Details),id);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Shop));
            }
            catch
            {
                return View();
            }
        }


    }
}