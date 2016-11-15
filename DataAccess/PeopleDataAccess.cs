using EntityTest.Models;
using EntityTest.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityTest.DataAccess {

    public class PeopleDataAccess : IDataAccess<Person>
    {
        public IEnumerable<Person> GetItems()
        {
            using (var PeopleDb = new PeopleDb()) {
                return PeopleDb.Person.ToList();
                PeopleDb.Set<Person>().ToList();    
            }
        }

        public Person GetById(int personId)
        {
            using (var PeopleDb = new PeopleDb()) {
                return PeopleDb.Person.FirstOrDefault(T => T.PersonId == personId);
            }
        }

        public void SaveItem(Person person)
        {
            using (var PeopleDb = new PeopleDb()) {
                PeopleDb.Person.Add(person);
                PeopleDb.SaveChanges();
            }
        }
    }

}