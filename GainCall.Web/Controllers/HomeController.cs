using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GainCall.Business.Managers;
using GainCall.Entity;
using GainCall.Web.Models;

namespace GainCall.Web.Controllers
{
    public class HomeController : Controller
    {

        public ProductManager ProductManager { get; set; }

        public HomeController()
        {
            ProductManager = new ProductManager();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            ProductSearchInfo productSearchInfo = new ProductSearchInfo();

           // productSearchInfo.States = ProductManager.GetStates();
            productSearchInfo.Cities = ProductManager.GetCities(1);
            ProductDetails pd = new ProductDetails();
      

            return View(productSearchInfo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
