using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntityTest.DataAccess;
using EntityTest.Models;

namespace EntityTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDataAccess db = new PeopleDataAccess();

            db.SavePerson(new Person {
                Firstname = "Chris",
                Lastname = "White",
                Age = 32
            });

            var people = db.GetPeople();

            foreach (var person in people) {
                Console.WriteLine("Firstname {0}, Lastname {1}, Age {2}", person.Firstname, person.Lastname, person.Age);
            }
            
        }
    }
}
