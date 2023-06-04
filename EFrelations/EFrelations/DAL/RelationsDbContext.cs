using EFrelations.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFrelations.DAL
{
    public class RelationsDbContext:DbContext
    {
        public RelationsDbContext(DbContextOptions<RelationsDbContext> options):base(options)
        {

        }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }

    }
}
