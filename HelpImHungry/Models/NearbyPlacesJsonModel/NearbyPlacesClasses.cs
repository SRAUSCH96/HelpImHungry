using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.Models.NearbyPlacesJsonModel
{

    public class NearbyPlacesObject
    {
        public object[] Html_attributions { get; set; }
        public string Next_page_token { get; set; }
        public Result[] Results { get; set; }
        public string Status { get; set; }
    }

    public class Result
    {
        public Geometry Geometry { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public Opening_Hours Opening_hours { get; set; }
        public Photo[] Photos { get; set; }
        public string Place_id { get; set; }
        public Plus_Code Plus_code { get; set; }
        public float Rating { get; set; }
        public string Reference { get; set; }
        public string Scope { get; set; }
        public string[] Types { get; set; }
        public int User_ratings_total { get; set; }
        public string Vicinity { get; set; }
        public int Price_level { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
        public Viewport Viewport { get; set; }
    }

    public class Location
    {
        public float Lat { get; set; }
        public float Lng { get; set; }
    }

    public class Viewport
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

    public class Opening_Hours
    {
        public bool Open_now { get; set; }
    }

    public class Plus_Code
    {
        public string Compound_code { get; set; }
        public string Global_code { get; set; }
    }

    public class Photo
    {
        public int Height { get; set; }
        public string[] Html_attributions { get; set; }
        public string Photo_reference { get; set; }
        public int Width { get; set; }
    }

}
