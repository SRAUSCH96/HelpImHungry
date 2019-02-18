using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpImHungry.Models;
using HelpImHungry.ViewModels;

namespace HelpImHungry.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            UserLocationViewModel model = new UserLocationViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLocationViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserLocation.Location = model.Location;
                
                var location = await Geocode.LoadGeocode();

                ViewBag.location = location;



                
                
                
                return View();
            }

            return View(model);

        
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
