using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        //Creating instance of IRestaurantData interface
        IRestaurantData db;

        //Constructor 
        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            //calling the get all function from interface
            var model = db.GetAll();
            return View(model);
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