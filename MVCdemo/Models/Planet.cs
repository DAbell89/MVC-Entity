using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCdemo.Models
{
    public class Planet
    {
        public int PlanetID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }

    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        public PlanetContext()
        {
            //Drops and Creates a New DataBase when Changes are made to model
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PlanetContext>());
        }
    }
}