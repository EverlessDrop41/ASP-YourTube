using System;
using System.Linq;
using YourTube.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace YourTube.Database
{
    public class YourTubeDbContext : IdentityDbContext<YourTubeUser>
    {
        DbSet<Theme> Themes;
        DbSet<Channel> Channels;
        DbSet<Page> Pages;

        public YourTubeDbContext(DbContextOptions<YourTubeDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Page>()
                .HasKey(b => b.Id)
                .HasName("PK_PageId");
            builder.Entity<Channel>();
            builder.Entity<Theme>();
        }
    }
}
