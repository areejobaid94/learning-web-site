using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBackEnd.models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
      : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Exception> Exceptions { get; set; }
    }
}
