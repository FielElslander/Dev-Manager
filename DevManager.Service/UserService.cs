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
    public class UserService : IService<AspNetUser>
    {
        private UserDAO _userDAO;

        public UserService()
        {
            _userDAO = new UserDAO();
        }
        public async System.Threading.Tasks.Task Add(AspNetUser entity)
        {
            await _userDAO.Add(entity);
        }

        public System.Threading.Tasks.Task Delete(AspNetUser entity)
        {
            return _userDAO.Delete(entity);
        }

        public Task<AspNetUser> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<AspNetUser> FindByUserId(string id)
        {
            return await _userDAO.FindByUserId(id);
        }

        public async Task<IEnumerable<AspNetUser>> GetAll()
        {
            return await _userDAO.GetAll();
        }

        public System.Threading.Tasks.Task Update(AspNetUser entity)
        {
            return _userDAO.Update(entity);
        }
    }
}
