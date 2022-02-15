using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PictureShare.Models;

namespace PictureShare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PictureModel> Pictures { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}