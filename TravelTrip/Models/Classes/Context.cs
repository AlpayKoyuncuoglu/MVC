using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTrip.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Communication> Communications{ get; set; }
        public DbSet<Comments> Comments { get; set; }


    }
}