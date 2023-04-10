using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<WorkImage> WorkImages { get; set; }

        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Offer> Offers { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
