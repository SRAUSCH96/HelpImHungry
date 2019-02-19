using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelpImHungry.Models
{
    public class Geocode
    {               
        //call geocode api to convert userlocation to long/lat
        public static async Task <LocationModel> LoadGeocode(string Address)
        {
            
            
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address= {Address}&key=AIzaSyAp4h1UeIBiWDZvJpfG6tlQFvEZwcwpmLg";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                   JsonLocation result = await response.Content.ReadAsAsync<JsonLocation>();

                    return result.Location;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                  

                    

                
                
                
            }
            
        }
    }
}
