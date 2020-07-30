using TerritoryWebPWA.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerritoryWebPWA.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Congregation> Congregations { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<DoorCode> DoorCodes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PublisherType> PublisherTypes { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<TerritoryAccess> TerritoryAccess { get; set; }
        public DbSet<TerritoryBound> TerritoryBounds { get; set; }
        public DbSet<TerritoryType> TerritoryTypes { get; set; }
        public DbSet<URLMinimizeStore> URLMinimizeStore { get; set; }
    }
}
