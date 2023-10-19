using DevManager.Domain.Entities;
using DevManager.Repositories;
using DevManager.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevManager.Service
{
    public class CalendarEventService : IService<CalendarEvent>
    {
        private CalendarEventDAO _CalendarEventDAO;

        public CalendarEventService()
        {
            _CalendarEventDAO = new CalendarEventDAO();
        }

        public async Task Add(CalendarEvent entity)
        {
            await _CalendarEventDAO.Add(entity);
        }

        public Task Delete(CalendarEvent entity)
        {
            return _CalendarEventDAO.Delete(entity);
        }

        public async Task<CalendarEvent> FindById(int Id)
        {
            return await _CalendarEventDAO.FindById(Id);
        }

        public async Task<IEnumerable<CalendarEvent>> GetAll()
        {
            return await _CalendarEventDAO.GetAll();
        }

        public Task Update(CalendarEvent entity)
        {
            return _CalendarEventDAO.Update(entity);
        }
    }
}
