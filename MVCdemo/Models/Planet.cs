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
        public string Faction { get; set; }
    }

    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        public PlanetContext()
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PlanetContext>());
            //Drops and Creates a New DataBase when Changes are made to model
            Database.SetInitializer(new MyInitializer());
        }

        public class MyInitializer : DropCreateDatabaseIfModelChanges<PlanetContext>
        {
            protected override void Seed(PlanetContext context)
            {
                base.Seed(context);
                context.Planets.Add(new Planet()
                {
                    Name = "Nova Prime",
                    Population = 846516,
                    Faction = "Nova Core"
                });
                context.SaveChanges();
            }
        }
    }
}