using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public enum Gender
    {
        MALE = 1,
        FEMALE
    }
    public enum HMO
    {
        MEUHEDET = 1,
        MACABI,
        KLALIT,
        LEUMIT
    }
    public class PersonalDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public HMO HMO { get; set; }
        public List<ChildrenModel> Childrens { get; set; }

    }
}
