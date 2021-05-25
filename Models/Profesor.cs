using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_ACTIONS.Models
{
    public class Profesor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    public class ProfDBContext : DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
    }
}