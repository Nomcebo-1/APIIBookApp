#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIIBookApp.Model;

namespace APIIBookApp.Data
{
    public class APIIBookAppContext : DbContext
    {
        public APIIBookAppContext (DbContextOptions<APIIBookAppContext> options)
            : base(options)
        {
        }

        public DbSet<APIIBookApp.Model.Book> Book { get; set; }
    }
}
