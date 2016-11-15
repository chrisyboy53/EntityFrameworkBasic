using System;
using EntityTest.DataAccess;
using EntityTest.Models;

namespace EntityTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDataAccess<Person> db = new PersonDataAccess();

            db.SaveItem(new Person {
                Firstname = "Chris",
                Lastname = "White",
                Age = 32
            });

            var people = db.GetItems();

            foreach (var person in people) {
                Console.WriteLine("Firstname {0}, Lastname {1}, Age {2}", person.Firstname, person.Lastname, person.Age);
            }
            
        }
    }
}
