using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesNET.Models;

namespace MoviesNET.Data
{
    public class MoviesNETContext : DbContext
    {
        public MoviesNETContext (DbContextOptions<MoviesNETContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesNET.Models.Movie> Movie { get; set; } = default!;
    }
}
