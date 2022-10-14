using EFCore6.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore6.Infrastructure
{
    public class EFCore6DbContext : DbContext
    {
        public EFCore6DbContext()
        {
        }

        public EFCore6DbContext(DbContextOptions<EFCore6DbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string basePath = Directory.GetCurrentDirectory().Replace("EFCore6.Infrastructure", "EFCore6");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<AccountUser> AccountUser { get; set; } = null!;
    }
}
