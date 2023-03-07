using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BryanCalderon.ArqLimpia.EN.Interfaces;

namespace BryanCalderon.ArqLimpia.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly BryanCalderonDbContext dbContext;

        public UnitOfWork(BryanCalderonDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();

        }
    }
}
