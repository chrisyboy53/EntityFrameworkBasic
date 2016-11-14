using Microsoft.EntityFrameworkCore;

namespace EntityTest.DataAccess.EntityFramework {

    public class PeopleDb : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./peoplesDB.db");
        }

        public DbSet<EntityTest.Models.Person> Person {get; set;}

    }

}