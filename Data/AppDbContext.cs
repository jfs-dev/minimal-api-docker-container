using Microsoft.EntityFrameworkCore;
using minimal_api_docker_container.Models;

namespace minimal_api_docker_container.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
}
