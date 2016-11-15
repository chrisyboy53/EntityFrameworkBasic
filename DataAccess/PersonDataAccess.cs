using System;
using EntityTest.Models;

namespace EntityTest.DataAccess {

    public class PersonDataAccess : BaseDataAccess<Person> {

        protected override Func<Person, int, bool> IdWhereClause 
        { 
            get 
            { 
                return (obj, id) => obj.PersonId == id; 
            }
         }

    }

}