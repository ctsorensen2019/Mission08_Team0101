using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0101.Models
{
    public class HabitContext : DbContext
    {
        public HabitContext(DbContextOptions<HabitContext> options) : base (options) //Constructor setting up options
        {
        
        }
    public DbSet<Habit> Habits { get; set; }
    public DbSet<Category> Categories { get; set; }

    }
}
