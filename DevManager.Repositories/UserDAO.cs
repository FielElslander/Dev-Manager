using DevManager.Domain.Data;
using DevManager.Domain.Entities;
using DevManager.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevManager.Repositories
{
    public class UserDAO : IDAO<AspNetUser>
    {
        private readonly DevManagerDbContext _dbContext;
        public async System.Threading.Tasks.Task Add(AspNetUser entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async System.Threading.Tasks.Task Delete(AspNetUser entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<AspNetUser> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AspNetUser> FindByUserId(string id)
        {
            try
            {
                return await _dbContext.AspNetUsers.Where(a => a.Id == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in UserDAO.FindByUserId()", ex);
            }
        }

        public async Task<IEnumerable<AspNetUser>> GetAll()
        {
            try
            {
                return await _dbContext.AspNetUsers.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in UserDAO.GetAll()", ex);
            }
        }

        public async System.Threading.Tasks.Task Update(AspNetUser entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
