using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class Communication
    {
        [Key]
        public int ID { get; set; }
        public int NameSurname{ get; set; }
        public string Mail { get; set; }
        public string Topic{ get; set; }
        public string Message{ get; set; }

          


    }
}