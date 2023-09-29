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
    public class CustomerService : IService<Customer>
    {
        private CustomerDAO _CustomerDAO;

        public CustomerService()
        {
            _CustomerDAO = new CustomerDAO();
        }
        public async Task Add(Customer entity)
        {
            await _CustomerDAO.Add(entity);
        }

        public Task Delete(Customer entity)
        {
            return _CustomerDAO.Delete(entity);
        }

        public async Task<Customer> FindById(int Id)
        {
            return await _CustomerDAO.FindById(Id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _CustomerDAO.GetAll();
        }

        public Task Update(Customer entity)
        {
            return _CustomerDAO.Update(entity);
        }
    }
}
