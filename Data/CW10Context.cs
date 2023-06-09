using Microsoft.EntityFrameworkCore;
using CW10.Models;

namespace CW10.Data;

public class CW10Context : DbContext
{
    public CW10Context(DbContextOptions<CW10Context> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; } = default!;

   
}