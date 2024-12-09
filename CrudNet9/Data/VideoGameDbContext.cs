using CrudNet9.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudNet9.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
    }
}
