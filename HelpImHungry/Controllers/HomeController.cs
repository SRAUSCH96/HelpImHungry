using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelpImHungry.Models;
using HelpImHungry.ViewModels;
using Microsoft.Extensions.Logging.Console.Internal;

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
                LocationModel UserLocation = new LocationModel { Location = model.Location, };
                

               UserLocation = await Geocode.LoadGeocode(UserLocation.Location);
                model.Lat = UserLocation.Lat;
                return View(model);
            }
            else
            {
                return View(model);
            }
                



                
                
                
                
            

           // return View(model);

        
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
