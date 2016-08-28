using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfMigrationDifferentDbs.Model;

namespace EfTest
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : this("PostgresDbConnection") { }

        public AppDbContext(string connStrName) : base(connStrName) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<User>()
                .Property(x => x.Name)
                .HasMaxLength(100);

            modelBuilder
                .Entity<User>()
                .Property(x => x.Age)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
