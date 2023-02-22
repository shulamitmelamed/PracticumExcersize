using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _3_Repository
{
    public class SQLDataSource:DbContext,IDataSource
    {
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=sqlsrv;Initial Catalog=#PracShulamitMelamed;Integrated Security=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer(@"Data Source=SHULAMIT-COMPUT;Initial Catalog=Practicum;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalDetails>().HasKey(x => new { x.PersonalDetailsId });
            modelBuilder.Entity<Children>().HasKey(x => new { x.ChildrenId });
        }
    }
}