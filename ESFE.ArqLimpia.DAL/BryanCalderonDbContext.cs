using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BryanCalderon.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace BryanCalderon.ArqLimpia.DAL
{
    public class BryanCalderonDbContext : DbContext
    {
        public BryanCalderonDbContext(DbContextOptions<BryanCalderonDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
