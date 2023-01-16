using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Travel.Entities;
using Microsoft.EntityFrameworkCore;


namespace Travel
{
    public class TravelDBContext: IdentityDbContext<User, IdentityRole<int>, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public TravelDBContext(DbContextOptions<TravelDBContext> opt ) :base (opt)
        {

        }
        public DbSet<Place> Pleaces { get; set; }
        public DbSet<Info> Infos { get; set; }
    }
}
