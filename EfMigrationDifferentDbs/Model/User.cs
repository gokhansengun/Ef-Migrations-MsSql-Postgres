using System;

namespace EfMigrationDifferentDbs.Model
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
