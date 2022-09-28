using System;
using Microsoft.EntityFrameworkCore;
using MiniAdventureDotNetWeb.Models;

namespace MiniAdventureDotNetWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
    }
}


