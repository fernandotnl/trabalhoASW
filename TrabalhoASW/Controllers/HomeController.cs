﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Models;

namespace TrabalhoASW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new ContextoBD())
            {
                Universidade uni = new Universidade();
                uni.nome = "Universidade1";
                context.universidades.Add(uni);
                context.SaveChanges();
                Console.WriteLine("");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}