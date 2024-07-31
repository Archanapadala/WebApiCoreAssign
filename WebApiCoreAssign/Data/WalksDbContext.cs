using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApiCoreAssign.Models.Domain;

namespace WebApiCoreAssign.Data
{

    public class WalksDbContext: DbContext
    {
        //db context class is used to communicate with the model class objects ,
        //it will connect with database and perform crud operations 
        public WalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        //constructor passing the parameters with options and calling the base class constructor 
        {
        }

            //models class are used with the help of dbset 
            

            public DbSet<Region> Regions{ get; set; }
            public DbSet<Difficulty> Difficulties { get; set; }
            public DbSet<Walks> Walks { get; set; }


    }
}
