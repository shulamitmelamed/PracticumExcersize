using _3_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IDataSource
    {
        public DbSet<Children> Childrens { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
