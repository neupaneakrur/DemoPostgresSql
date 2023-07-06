using Microsoft.EntityFrameworkCore;
using DemoPostgresSql.Data.Entities;

public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
