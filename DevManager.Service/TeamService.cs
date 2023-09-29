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
    public class TeamService : IService<Team>
    {
        private TeamDAO _TeamDAO;

        public TeamService()
        {
            _TeamDAO = new TeamDAO();
        }
        public async System.Threading.Tasks.Task Add(Team entity)
        {
            await _TeamDAO.Add(entity);
        }

        public System.Threading.Tasks.Task Delete(Team entity)
        {
            return _TeamDAO.Delete(entity);
        }

        public async Task<Team> FindById(int Id)
        {
            return await _TeamDAO.FindById(Id);
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _TeamDAO.GetAll();
        }

        public System.Threading.Tasks.Task Update(Team entity)
        {
            return _TeamDAO.Update(entity);
        }
    }
}
