using DSAndAlgorithms.DataStructures.LinkedList;

namespace DSAndAlgorithms.DataStructures.Sets
{
    internal class HashSet<T>
    {
        private const int No_Of_Buckets = 10;
        private const int THRESHOLD = 10;

        private Node<T>[] buckets;

        public int Size { get; private set; }

        public HashSet()
        {
            Size = 0;
            buckets=new Node<T>[No_Of_Buckets];
            
            for (int i = 0; i < No_Of_Buckets; i++)
            {
                buckets[i] = new Node<T>();
            }
        }

        public bool Contains(T element)
        {
            int bucketNumber = element.GetHashCode()%buckets.Length;
            return LinkedList<T>.Contains(buckets[bucketNumber], element);
        }

        public void Add(T element)
        {
            int bucketNumber = element.GetHashCode()% No_Of_Buckets;
            LinkedList<T>.Add(buckets[bucketNumber], element);
            ++Size;
        }
    }
}
