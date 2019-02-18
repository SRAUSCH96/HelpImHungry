using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpImHungry.ViewModels
{
    public class UserLocationViewModel
    {
        [Required]
        public string Location { get; set; }


    }
}
