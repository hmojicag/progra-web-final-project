using Microsoft.EntityFrameworkCore;

namespace finalproyect.Model {
    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) {
        }
        
        public DbSet<Music> Musics { get; set; }
        
    }
}