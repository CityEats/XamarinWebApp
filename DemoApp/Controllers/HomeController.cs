using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(bool manifold = false)
        {
            var r = new Random();
            var restaurants = new List<RestaurantWaitTime>();
            ViewBag.Manifold = manifold;
            restaurants.Add(new RestaurantWaitTime { Name = "Fig", Minutes = r.Next(0, 5)});
            restaurants.Add(new RestaurantWaitTime { Name = "Fork", Minutes = r.Next(0, 5) });
            restaurants.Add(new RestaurantWaitTime { Name = "Plate", Minutes = r.Next(0, 5) });
            restaurants.Add(new RestaurantWaitTime { Name = "Cup", Minutes = r.Next(0, 5) });
            return View(restaurants);
        }
    }
}
