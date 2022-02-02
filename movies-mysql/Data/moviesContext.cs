#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies_mysql.Models;

    public class moviesContext : DbContext
    {
        public moviesContext (DbContextOptions<moviesContext> options)
            : base(options)
        {
        }

        public DbSet<movies_mysql.Models.Movie> Movie { get; set; }
    }
