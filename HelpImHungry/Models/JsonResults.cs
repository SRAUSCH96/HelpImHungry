using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.Models
{
    
    

        public class Rootobject
        {
            public Result[] Results { get; set; }
            public string Status { get; set; }
        }

        public class Result
        {
            public Address_Components[] Address_components { get; set; }
            public string Formatted_address { get; set; }
            public Geometry Geometry { get; set; }
            public string Place_id { get; set; }
            public string[] Types { get; set; }
        }

        public class Geometry
        {
            public Bounds Bounds { get; set; }
            public Location Location { get; set; }
            public string Location_type { get; set; }
            public Viewport Viewport { get; set; }
        }

        public class Bounds
        {
            public Northeast Northeast { get; set; }
            public Southwest Southwest { get; set; }
        }

        public class Northeast
        {
            public float Lat { get; set; }
            public float Lng { get; set; }
        }

        public class Southwest
        {
            public float Lat { get; set; }
            public float Lng { get; set; }
        }

        public class Location
        {
            public double Lat { get; set; }
            public double Lng { get; set; }
        }

        public class Viewport
        {
            public Northeast1 Northeast { get; set; }
            public Southwest1 Southwest { get; set; }
        }

        public class Northeast1
        {
            public float Lat { get; set; }
            public float Lng { get; set; }
        }

        public class Southwest1
        {
            public float Lat { get; set; }
            public float Lng { get; set; }
        }

        public class Address_Components
        {
            public string Long_name { get; set; }
            public string Short_name { get; set; }
            public string[] Types { get; set; }
        }

    
}
