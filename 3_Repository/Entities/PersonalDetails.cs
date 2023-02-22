using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public enum Gender
    {
        MALE=1,
        FEMALE
    }
    public enum HMO
    {
        MEUHEDET=1,
        MACABI,
        KLALIT,
        LEUMIT
    }
    public class PersonalDetails
    {
        public int PersonalDetailsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public HMO HMO { get; set; }
        public List<Children> Childrens { get; set; }
        //public virtual ICollection<Children> Children { get; } = new List<Children>();


        //public PersonalDetails(string firstName, string lastName, string id, DateTime dateOfBirth, Gender gender, HMO hMO, List<Children> childrens)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Id = id;
        //    DateOfBirth = dateOfBirth;
        //    Gender = gender;
        //    HMO = hMO;
        //    Childrens = childrens;
        //}

        //public PersonalDetails()
        //{
        //}
    }
}
