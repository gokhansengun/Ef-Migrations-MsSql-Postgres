using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfMigrationDifferentDbs.Model;

namespace EfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var appDbContext = new AppDbContext())
            {
                appDbContext.Users.Add(new User()
                {
                    Id = Guid.NewGuid(),
                    Age = 10,
                    Name = "Gokhan Sengun"
                });

                appDbContext.SaveChanges();
            }
        }
    }
}



