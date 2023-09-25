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
    public class AssignmentDAO : IDAO<Assignment>
    {
        private readonly DevManagerDbContext _dbContext;
        public async System.Threading.Tasks.Task Add(Assignment entity)
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

        public async System.Threading.Tasks.Task Delete(Assignment entity)
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

        public async Task<Assignment> FindById(int id)
        {
            try
            {
                return await _dbContext.Assignments.Where(a => a.AssignmentId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in AssignmentDAO.FindById()", ex);
            }
        }

        public async Task<IEnumerable<Assignment>> GetAll()
        {
            try
            {
                return await _dbContext.Assignments.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in assignmentDAO.GetAll()", ex);
            }
        }

        public async System.Threading.Tasks.Task Update(Assignment entity)
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
