﻿using DevManager.Domain.Data;
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
    public class ProjectDAO : IDAO<Project>
    {
        private readonly DevManagerDbContext _dbContext;
        public async System.Threading.Tasks.Task Add(Project entity)
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

        public async System.Threading.Tasks.Task Delete(Project entity)
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

        public async Task<Project> FindById(int id)
        {
            try
            {
                return await _dbContext.Projects.Where(a => a.ProjectId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in ProjectDAO.FindById()", ex);
            }
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            try
            {
                return await _dbContext.Projects.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in ProjectDAO.GetALl()", ex);
            }
        }

        public async System.Threading.Tasks.Task Update(Project entity)
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
