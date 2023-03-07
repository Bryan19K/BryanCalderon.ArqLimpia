using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BryanCalderon.ArqLimpia.EN;
using BryanCalderon.ArqLimpia.EN.Interfaces;
using Microsoft.EntityFrameworkCore;
using BryanCalderon.ArqLimpia.DAL;

namespace MISAEL.ArqLimpia.DAL
{
    public class UserDAL : IUser
    {
        readonly BryanCalderonDbContext dbContext;

        public UserDAL(BryanCalderonDbContext pdbContext)
        {
            dbContext = pdbContext;
        }

        //METODO CREAR
        public void Create(User pUser)
        {
            dbContext.Add(pUser);
        }

        //METODO ELIMINAR
        public void Delete(User pUser)
        {
            dbContext.Remove(pUser);
        }


        //METODO GETBYID
        public async Task<User> GetById(User pUser)
        {
            User? user = await dbContext.User.FirstOrDefaultAsync(s => s.Id == pUser.Id);
            if (user != null)
                return user;
            else
                return new User();
        }


        //METODO BUSCAR
        public Task<List<User>> Search(User pUser)
        {
            var query = dbContext.User.AsQueryable();
            if (!string.IsNullOrWhiteSpace(pUser.Name))
                query = query.Where(s => s.Name.Contains(pUser.Name));
            if (!string.IsNullOrWhiteSpace(pUser.Email))
                query = query.Where(s => s.Email == pUser.Email);
            return query.ToListAsync();
        }


        //METODO ACTUALIZAR
        public void Update(User pUser)
        {
            dbContext.Update(pUser);
        }
    }
}