using Microsoft.EntityFrameworkCore;
using MyMusicA.Models;

namespace MyMusicA
{
    public class SongDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public SongDbContext(DbContextOptions<SongDbContext> options)
            : base(options)
        {

        }
    }
}
