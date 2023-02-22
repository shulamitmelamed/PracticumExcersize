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
    public class PersonalDetailsRepository : IPersonalDetailsRepository
    {
        private readonly IDataSource dataSource;

        public PersonalDetailsRepository(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public async Task<List<PersonalDetails>> GetAllAsync()
        {
            return await dataSource.PersonalDetails.ToListAsync();
        }
        public async Task<PersonalDetails> GetByIdAsync(int id)
        {
            return await dataSource.PersonalDetails.FindAsync(id);
        }
        public async Task<PersonalDetails> AddAsync(PersonalDetails model)
        {
            dataSource.PersonalDetails.Add(model);
            await dataSource.SaveChangesAsync();
            return model;
        }
        public void  UpdateAsync(PersonalDetails model)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteAsync(int id)
        {
            dataSource.PersonalDetails.Remove(await GetByIdAsync(id));
            await dataSource.SaveChangesAsync();
        }






    }
}
