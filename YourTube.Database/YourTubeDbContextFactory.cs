using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTube.Database
{
    public class YourTubeDbContextFactory
    {
        public const string DEV_CONNECTION_STRING = @"Server=(localdb)\mssqllocaldb;Database=YourTubeDb;Trusted_Connection=True;MultipleActiveResultSets=True;";
        public const string PROD_CONNECTION_STRING = @"Server=(localdb)\mssqllocaldb;Database=YourTubeDb;Trusted_Connection=True;MultipleActiveResultSets=True;";
        public static bool InProduction = false;

        public static string GetConnectionString()
        {
            return InProduction ? PROD_CONNECTION_STRING : DEV_CONNECTION_STRING;
        }

        public YourTubeDbContext Create()
        {
            var optionsBuilder = new DbContextOptionsBuilder<YourTubeDbContext>();

            optionsBuilder.UseSqlServer(GetConnectionString());

            return new YourTubeDbContext(optionsBuilder.Options);
        }

        public YourTubeDbContext CreateWithMigrationAssemby(string AssemblyName)
        {
            var optionsBuilder = new DbContextOptionsBuilder<YourTubeDbContext>();

            optionsBuilder.UseSqlServer(GetConnectionString(),
                b => b.MigrationsAssembly(AssemblyName));

            return new YourTubeDbContext(optionsBuilder.Options);
        }
    }
}
