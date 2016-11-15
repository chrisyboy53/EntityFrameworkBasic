using System.Collections.Generic;
using EntityTest.Models;

namespace EntityTest.DataAccess
{
    public interface IDataAccess {

        IEnumerable<Person> GetPeople();

        Person GetPersonById(int personId);

        void SavePerson(Person person);

    }
}