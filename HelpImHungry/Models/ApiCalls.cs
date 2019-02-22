using HelpImHungry.Models.GeocodeJsonModel;
using HelpImHungry.Models.NearbyPlacesJsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelpImHungry.Models
{
    public class GeocodeCall
    {
        //call geocode api to get long/lat
        public static async Task<GeocodeJsonModel.Location> LoadGeocode(string Address)
        {

            GeocodeJsonObject JsonGeo = null;
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address= {Address} &key=AIzaSyAp4h1UeIBiWDZvJpfG6tlQFvEZwcwpmLg";

            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                JsonGeo = await response.Content.ReadAsAsync<GeocodeJsonObject>();
                return JsonGeo.Results[0].Geometry.Location;
            }

            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
    public class NearbyRestaurantsCall
    {
        public static async Task<NearbyPlacesJsonModel.Result[]> LoadRestaurants(double Lat, double Lng)
        {

            NearbyPlacesObject RestaurantObject = null;
            string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + Lat +"," + Lng + "&rankby=distance&type=restaurant&key=AIzaSyAp4h1UeIBiWDZvJpfG6tlQFvEZwcwpmLg";

            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                RestaurantObject = await response.Content.ReadAsAsync<NearbyPlacesObject>();
                return RestaurantObject.Results;
            }

            else
            {
                throw new Exception(response.ReasonPhrase);
            }


        }

    }

}
