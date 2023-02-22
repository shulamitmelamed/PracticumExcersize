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
    public class ChildrenService : IChildrenService
    {

        IChildrenRepository rep;
        IMapper mapper;
        public ChildrenService(IChildrenRepository rep, IMapper mapper)
        {
            this.rep = rep;
            this.mapper=mapper;
        }
        public async Task<ChildrenModel> AddAsync(ChildrenModel model)
        {
            return mapper.Map<ChildrenModel>(await rep.AddAsync(mapper.Map<Children>(model)));
        }

        public async Task DeleteAsync(int id)
        {
            await rep.DeleteAsync(id);
        }

        public async Task<List<ChildrenModel>> GetAllAsync()
        {
            List<Children> children = await rep.GetAllAsync();
            var listToReturn = new List<ChildrenModel>();
            foreach (var item in children)
            {
                listToReturn.Add(mapper.Map<ChildrenModel>(item));

            }
            return listToReturn;
        }

        public async Task<ChildrenModel> GetByIdAsync(int id)
        {
            return mapper.Map<ChildrenModel>(await rep.GetByIdAsync(id));
        }

        public void UpdateAsync(ChildrenModel model)
        {
            throw new NotImplementedException();
        }
    }
}
