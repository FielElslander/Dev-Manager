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
    public class TeamDAO : IDAO<Team>
    {
        private readonly DevManagerDbContext _dbContext;
        public async System.Threading.Tasks.Task Add(Team entity)
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

        public async System.Threading.Tasks.Task Delete(Team entity)
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

        public async Task<Team> FindById(int id)
        { 
            try
            {
                return await _dbContext.Teams.Where(a => a.TeamId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in TaskDAO.FindById()", ex);
            }
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            try
            {
                return await _dbContext.Teams.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in TeamDAO.GetAll()", ex);
            }
        }

        public async System.Threading.Tasks.Task Update(Team entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
