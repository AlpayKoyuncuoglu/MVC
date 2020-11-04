using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class Blog { 
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Tarih { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comments> Comment{ get; set; }

    }
}