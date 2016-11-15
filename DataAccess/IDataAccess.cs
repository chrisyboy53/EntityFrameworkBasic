using System.Collections.Generic;
using EntityTest.Models;

namespace EntityTest.DataAccess
{
    public interface IDataAccess<T> where T: class {

        IEnumerable<T> GetItems();

        T GetById(int id);

        void SaveItem(T obj);

    }
}