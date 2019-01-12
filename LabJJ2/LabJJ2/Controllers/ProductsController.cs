using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabJJ2.Models;

namespace LabJJ2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(Products model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View("Index", model);
        }

        //public ActionResult Add(Products model)
        //{
        //    return View("Index", model);
        //}

    }
}