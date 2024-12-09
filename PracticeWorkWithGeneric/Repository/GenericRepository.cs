using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7.PracticeWorkWithGeneric.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {

        private readonly List<T> _list;

        public GenericRepository()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            return _list.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine("Products saved");
        }
    }
}
