namespace MoviesRental.Migrations
{
    using MoviesRental.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesRental.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(MoviesRental.Models.ApplicationDbContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data.
        //}

        protected override void Seed(MoviesRental.Models.ApplicationDbContext context)
        {
            context.Customers.AddOrUpdate(i => i.Name,
                new Customer
                {
                    Name = "Pepo San Martín",
                    Birthdate = DateTime.Parse("1989-1-11"),
                    IsSubscribedToNewsletter = false,
                    MembershipTypeId = 1
                },

                new Customer
                {
                    Name = "Diego San Andre",
                    Birthdate = DateTime.Parse("1981-2-10"),
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 2
                },

                   new Customer
                   {
                       Name = "Juan de los Palotes",
                       Birthdate = null,
                       IsSubscribedToNewsletter = true,
                       MembershipTypeId = 4
                   }
           );

        }
    }
}
