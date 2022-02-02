#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies_app.Models;

    public class moviesAppContext : DbContext
    {
        public moviesAppContext (DbContextOptions<moviesAppContext> options)
            : base(options)
        {
        }

        public DbSet<movies_app.Models.Movie> Movie { get; set; }
    }
