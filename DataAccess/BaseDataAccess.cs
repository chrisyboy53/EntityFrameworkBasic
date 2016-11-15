using System;
using System.Collections.Generic;
using System.Linq;
using EntityTest.DataAccess.EntityFramework;

namespace EntityTest.DataAccess {
    public abstract class BaseDataAccess<T> : IDataAccess<T>  where T: class {

        protected abstract Func<T, int, bool> IdWhereClause { get; }

        public virtual T GetById(int id)
        {
            using(PeopleDb db = new PeopleDb()) {
                return db.Set<T>().FirstOrDefault(obj => IdWhereClause(obj, id));
            }
        }

        public virtual IEnumerable<T> GetItems()
        {
            IEnumerable<T> results = null;

            using(PeopleDb db = new PeopleDb()) {
                results = db.Set<T>().ToList();
            }

            return results;
        }

        public virtual void SaveItem(T obj)
        {
            using(PeopleDb db = new PeopleDb()) {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }
        }
    }
}