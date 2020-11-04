using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string AdressDetail { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string location { get; set; }



    }
}