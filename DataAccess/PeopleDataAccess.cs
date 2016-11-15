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
            }
        }

        public Person GetById(int id)
        {
            using (var PeopleDb = new PeopleDb()) {
                return PeopleDb.Person.FirstOrDefault(T => T.PersonId == id);
            }
        }

        public void SaveItem(Person obj)
        {
            using (var PeopleDb = new PeopleDb()) {
                PeopleDb.Person.Add(obj);
                PeopleDb.SaveChanges();
            }
        }
    }

}