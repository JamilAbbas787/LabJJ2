﻿using System;
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
        public ActionResult Index()
        {
 

            return View();
        }

        public ActionResult Add(Products model)
        {

            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View("Index", model);
        }

    }
}