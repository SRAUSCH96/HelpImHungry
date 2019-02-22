using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.Models.GeocodeJsonModel
{
    
    

        public class GeocodeJsonObject
        {
            public Result[] Results { get; set; }
            public string Status { get; set; }
        }

        public class Result
        {      
            public string Formatted_address { get; set; }
            public Geometry Geometry { get; set; }
            public string Place_id { get; set; }
            public string[] Types { get; set; }
        }

        public class Geometry
        {          
            public Location Location { get; set; }
            public string Location_type { get; set; }
            
        }       

        public class Location
        {
            public double Lat { get; set; }
            public double Lng { get; set; }
        }

        

    
}
