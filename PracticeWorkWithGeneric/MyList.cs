using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7.PracticeWorkWithGeneric
{
    public class MyList <T>
    {
        private List<T> list = new List<T>();

        public void Add (T item)
        {
            list.Add(item);
        }

        public T Remove (int index) { 
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public bool Contains (T item)
        {
            return list.Contains(item);
        }

        public void Clear ()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index > list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            list.RemoveAt(index);
        }

        public T Find (int index)
        {
            if (index < 0 || index > list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return list[index];
        }

    }
}
