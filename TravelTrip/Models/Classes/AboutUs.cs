using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class AboutUs
    {
        [Key]
        public int ID { get; set; }
        public string Picture { get; set; }
        public string Explanation { get; set; }



    }
}