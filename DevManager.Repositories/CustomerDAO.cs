using DevManager.Domain.Data;
using DevManager.Domain.Entities;
using DevManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevManager.Repositories
{
    public class CustomerDAO : IDAO<Customer>
    {
        private readonly DevManagerDbContext _dbContext;
        public async System.Threading.Tasks.Task Add(Customer entity)
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

        public async System.Threading.Tasks.Task Delete(Customer entity)
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

        public async Task<Customer> FindById(int id)
        {
            try
            {
                return await _dbContext.Customers.Where(a => a.CustomerId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in CustomerDAO.FindById()", ex);
            }
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            try
            {
                return await _dbContext.Customers.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in CustomerDao.GetAll()", ex);
            }
        }

        public async System.Threading.Tasks.Task Update(Customer entity)
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
