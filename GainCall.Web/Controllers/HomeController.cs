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

            ProductSearchInfo productSearchInfo = new ProductSearchInfo
            {
                States = ProductManager.GetStates(),
                Cities = ProductManager.GetCities(1),
                ProductTypes = ProductManager.GetProductTRepository()

            };
            return View(productSearchInfo);
        }
        [HttpPost]
        public ActionResult GetCitiesByStateId(string stateId)
        {
            int statId;
            List<SelectListItem> districtNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(stateId))
            {
                statId = Convert.ToInt32(stateId);
                List<City> districts = ProductManager.GetCities(statId);
                districts.ForEach(x =>
                {
                    districtNames.Add(new SelectListItem { Text = x.Name, Value = x.CityId.ToString() });
                });
            }
            return Json(districtNames, JsonRequestBehavior.AllowGet);
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

        [HttpPost]
        public ActionResult Index(ProductSearchInfo productSearchInfo)
        {
            if (ModelState.IsValid)
            {
                return Json("Success", JsonRequestBehavior.AllowGet);
            }

            productSearchInfo = new ProductSearchInfo
            {
                States = ProductManager.GetStates(),
                Cities = ProductManager.GetCities(productSearchInfo.StateId),
                ProductTypes = ProductManager.GetProductTRepository()

            };


            return View(productSearchInfo);
        }
    }
}
