using _3_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ChildrenModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        //public PersonalDetails PersonalDetails { get; set; }
        //public string PersonalDetailsId { get; set; }


    }
}
