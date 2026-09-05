using dotnet_backend_template_unicomTic.Entity;
using Microsoft.EntityFrameworkCore;

namespace dotnet_backend_template_unicomTic.ApplicationDbContext
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
    {

    }

    public DbSet<Student> student { get; set; }
    public DbSet<Course> course { get; set; }
  }
}
