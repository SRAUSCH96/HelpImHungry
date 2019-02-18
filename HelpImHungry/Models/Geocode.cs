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
        public static async Task<UserLocation> LoadGeocode()
        {
            
            
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={ UserLocation.Location }&key=AIzaSyAp4h1UeIBiWDZvJpfG6tlQFvEZwcwpmLg";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                  await response.Content.ReadAsAsync<ApiResults>();
                    
                    return ApiResults.Results;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            
        }
    }
}
