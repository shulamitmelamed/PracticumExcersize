using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ChildrensRepository : IChildrenRepository
    {
        private readonly IDataSource dataSource;
        public ChildrensRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<List<Children>> GetAllAsync()
        {
            return await dataSource.Childrens.ToListAsync();
        }

        public async Task<Children> GetByIdAsync(int id)
        {
            return await dataSource.Childrens.FindAsync(id);
        }

        public async Task<Children> AddAsync(Children model)
        {
            dataSource.Childrens.Add(model);
            await dataSource.SaveChangesAsync();    
            return model;
        }

        public void UpdateAsync(Children model)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteAsync(int id)
        {
            dataSource.Childrens.Remove(await GetByIdAsync(id));
            await dataSource.SaveChangesAsync();
        }

        
        
        
    }
}
