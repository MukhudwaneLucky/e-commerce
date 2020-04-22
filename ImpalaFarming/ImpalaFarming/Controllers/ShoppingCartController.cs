using System;
using ImpalaFarming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImpalaFarming.Controllers
{
    public class ShoppingCartController : Controller
    {
        public ImpalaFarmingDB db = new ImpalaFarmingDB();
        // GET: ShoppingCart
        public ActionResult Cart(int id)
        {
            return View(db.ShoppingCarts.Find(id));
        }
        /*
        // GET: ShoppingCart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        */

        // GET: ShoppingCart/Create
        public ActionResult AddItem()
        {
            return View();
        }

       

        // GET: ShoppingCart/Edit/5
        public ActionResult UpdateQuantity(int id)
        {
            return View();
        }

        // POST: ShoppingCart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateQuantity(int id, ShoppingCart cart)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction(nameof(Cart),id);
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCart/Delete/5
        public ActionResult DeleteItem(int id)
        {
            return View();
        }

        // POST: ShoppingCart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ShoppingCart cart)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Cart),id);
            }
            catch
            {
                return View();
            }
        }

    }
}