using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Sets
{
    public class Set<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private readonly List<T> items = new List<T>();

        public Set()
        {

        }

        public Set(IEnumerable<T> items)
        {
            this.AddRange(items);
        }

        private void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            if (items.Contains(item))
            {
                throw new InvalidOperationException("Item already exists in the Set");
            }
            else
            {
                items.Add(item);
            }
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
