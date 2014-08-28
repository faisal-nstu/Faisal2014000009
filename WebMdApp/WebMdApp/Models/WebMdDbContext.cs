using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMdApp.Models
{
    public class WebMdDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Article> Articles { set; get; }
    }
}