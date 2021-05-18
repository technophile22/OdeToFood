using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class OdeToFoodDBContext : DbContext
    {
        //connection file
        //By naming this as Restaurants
        //We are telling the entity framework that there will be a
        //table named Restaurants in the database
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
