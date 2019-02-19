using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.ViewModels
{
    public class LocationViewModel
    {
        [Required]
        public string Location { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public LocationViewModel() { }

    }
}
