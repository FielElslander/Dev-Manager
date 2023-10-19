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
    public class CalendarEventDAO : IDAO<CalendarEvent>
    {
        private readonly DevManagerDbContext _dbContext;
        public async Task Add(CalendarEvent entity)
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

        public async Task Delete(CalendarEvent entity)
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

        public async Task<CalendarEvent> FindById(int id)
        {
            try
            {
                return await _dbContext.CalendarEvents.Where(c => c.EventId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in CalendarEventDAO.findById()", ex);
            }
        }

        public async Task<IEnumerable<CalendarEvent>> GetAll()
        {
            try
            {
                return await _dbContext.CalendarEvents.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in CalendarEventDAO.getall", ex);
            }
        }

        public async Task Update(CalendarEvent entity)
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
