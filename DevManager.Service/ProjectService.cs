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
    public class ProjectService : IService<Project>
    {
        private ProjectDAO _ProjectDAO;

        public ProjectService()
        {
            _ProjectDAO = new ProjectDAO();
        }
        public async System.Threading.Tasks.Task Add(Project entity)
        {
            await _ProjectDAO.Add(entity);
        }

        public System.Threading.Tasks.Task Delete(Project entity)
        {
            return _ProjectDAO.Delete(entity);
        }

        public async Task<Project> FindById(int Id)
        {
            return await _ProjectDAO.FindById(Id);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _ProjectDAO.GetAll();
        }

        public System.Threading.Tasks.Task Update(Project entity)
        {
            return _ProjectDAO.Update(entity)
        }
    }
}
;