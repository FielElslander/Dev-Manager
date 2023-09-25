using DevManager.Domain.Entities;
using DevManager.Repositories;
using DevManager.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace DevManager.Service
{
    public class AssignmentService : IService<Assignment>
    {
        private AssignmentDAO _AssignmentDAO;

        public AssignmentService()
        {
            _AssignmentDAO = new AssignmentDAO();
        }
        public async Task Add(Assignment entity)
        {
            await _AssignmentDAO.Add(entity);
        }

        public Task Delete(Assignment entity)
        {
            return _AssignmentDAO.Delete(entity);
        }

        public async Task<Assignment> FindById(int Id)
        {
            return await _AssignmentDAO.FindById(Id);
        }

        public async Task<IEnumerable<Assignment>> GetAll()
        {
            return await _AssignmentDAO.GetAll();
        }

        public Task Update(Assignment entity)
        {
            return _AssignmentDAO.Update(entity);
        }
    }
}
