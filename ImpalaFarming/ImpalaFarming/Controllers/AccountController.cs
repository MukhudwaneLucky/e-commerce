using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ImpalaFarming.Models;

namespace ImpalaFarming.Controllers
{
    public class AccountController : Controller
    {
        public ImpalaFarmingDB db = new ImpalaFarmingDB();
        // GET: Account
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                try
                {
                    // TODO: Add insert logic here
                    db.Add(new User
                    {
                        first_name = user.first_name,
                        last_name = user.last_name,
                        street_name = user.street_name,
                        town = user.town,
                        city = user.city,
                        zip_code = user.zip_code,
                        province = user.province,
                        email = user.email,
                        password = user.password,
                        phone_number = user.phone_number,
                        user_type = "CUSTOMER"
                    });
                    db.SaveChanges();

                }
                catch (Exception ex) { ViewBag.Error = "Exc : " + ex.GetBaseException() + ex.InnerException + ex.Message;  return View(); }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, User user)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Logout));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            try
            {
                return RedirectToAction("Shop", "Product");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult ResetPassword(int id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword(int id,User user)
        {
            try
            {
                return RedirectToAction(nameof(Login));
            }
            catch (Exception)
            {
                return View();
            }
        }


    }
}