using _2_Services.Models;
using _3_Repository.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<PersonalDetails, PersonalDetailModel>().ReverseMap();
            CreateMap<Children, ChildrenModel>().ReverseMap();
        }
    }
}
