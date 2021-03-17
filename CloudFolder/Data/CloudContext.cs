using CloudFolder.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFolder.Data
{
    public class CloudContext : DbContext
    {
        public CloudContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<File> Files {get;set;}
        public DbSet<Folder> Folders {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = Desktop-9ep80dv; Database = CloudFolder; Trusted_Connection = true");
        }
    }
}
