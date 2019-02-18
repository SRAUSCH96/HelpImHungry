using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelpImHungry.Models
{
    public class RestaurantData
    {
        string key = "&key=AIzaSyAp4h1UeIBiWDZvJpfG6tlQFvEZwcwpmLg";
        public async Task GetPlace(string place)
        {
            //example google api url for restaurant https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=1500&type=restaurant&keyword=cruise&key=YOUR_API_KEY
            string url = "https://maps.googleapis.com/maps/api/place/findplacefromtext/json?input=st.%louis&inputtype=textquery&" + key;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                }

            }
        }

        
      
    }

}
