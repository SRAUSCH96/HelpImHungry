using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpImHungry.Models;
using HelpImHungry.ViewModels;
using Microsoft.Extensions.Logging.Console.Internal;
using Newtonsoft.Json;
using System.Net.Http;

namespace HelpImHungry.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            LocationViewModel model = new LocationViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(LocationViewModel model)
        {
            
            if (ModelState.IsValid)
            {
               

                var UserLocation = await GeocodeCall.LoadGeocode(model.Location);
                RestaurantData.Restaurants = await NearbyRestaurantsCall.LoadRestaurants(UserLocation.Lat, UserLocation.Lng);
                RestaurantData.Randomize();
                return Redirect("/home/restaurants");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Restaurants()
        {

            
            ViewBag.info = RestaurantData.Restaurants[1].Name;

            return View(RestaurantData.Restaurants);
        }

    }



        
        
    
}
