using _2_Services.Interfaces;
using _2_Services.Models;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Services
{
    public class PersonalDetailsService : IPersonalDetailsService
    {

        IPersonalDetailsRepository rep;
        IMapper mapper;
        public PersonalDetailsService(IPersonalDetailsRepository repository, IMapper mapper)
        {
            this.rep = repository;
            this.mapper = mapper;
        }
        public async Task<PersonalDetailModel> AddAsync(PersonalDetailModel model)
        {
            return mapper.Map<PersonalDetailModel>(await rep.AddAsync(mapper.Map<PersonalDetails>(model)));
        }

        public async Task DeleteAsync(int id)
        {
            rep.DeleteAsync(id);
        }

        public async Task<List<PersonalDetailModel>> GetAllAsync()
        {
            List<PersonalDetails> personals = await rep.GetAllAsync();
            var listToReturn = new List<PersonalDetailModel>();
            foreach (var item in personals)
            {
                listToReturn.Add(mapper.Map<PersonalDetailModel>(item));
            }
            return listToReturn;
        }

        public async Task<PersonalDetailModel> GetByIdAsync(int id)
        {
            return mapper.Map<PersonalDetailModel>(await rep.GetByIdAsync(id));
        }

        public void UpdateAsync(PersonalDetailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
