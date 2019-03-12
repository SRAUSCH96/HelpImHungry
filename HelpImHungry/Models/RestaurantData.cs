using HelpImHungry.Models.NearbyPlacesJsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.Models
{
    public static class RestaurantData
    {
        public static Result[] Restaurants { get; set; }
        public static Result[] RandomRestaurants { get; set; }
        public static Result[] DistanceRestaurants { get; set; }

        public static void Randomize()
        {
            Random r = new Random();
           RestaurantData.RandomRestaurants = RestaurantData.Restaurants.OrderBy(x => r.Next()).ToArray();
                       
        // TO REMOVE INVALID LOCATIONS
            //for (int i = 0; i < Restaurants.Count(); i++)
            // {
            //  foreach (object type in Restaurants[i].Types)
            //     {
            //   if (  )
            //  }
            // }
            
                                            
        }
    }
}
