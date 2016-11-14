using EntityTest.Models;
using EntityTest.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityTest.DataAccess {

    public class PeopleDataAccess : IDataAccess
    {
        public IEnumerable<Person> GetPeople()
        {
            using (var PeopleDb = new PeopleDb()) {
                return PeopleDb.Person.ToList();    
            }
        }

        public Person GetPersonById(int personId)
        {
            using (var PeopleDb = new PeopleDb()) {
                return PeopleDb.Person.FirstOrDefault(T => T.PersonId == personId);
            }
        }

        public void SavePerson(Person person)
        {
            using (var PeopleDb = new PeopleDb()) {
                PeopleDb.Person.Add(person);
                PeopleDb.SaveChanges();
            }
        }
    }

}