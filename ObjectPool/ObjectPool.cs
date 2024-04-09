using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class ObjectPool<T> where T : new()
    {
        private List<T> _pool = new List<T>();
        private int _maxSize;

        public ObjectPool(int maxSize)
        {
            _maxSize = maxSize;
        }

        public T BorrowObject()
        {
            if (_pool.Count > 0)
            {
                T obj = _pool[0];
                _pool.RemoveAt(0);
                return obj;
            }
            else
            {
                return new T();
            }
        }

        public void ReturnObject(T obj)
        {
            if (_pool.Count < _maxSize)
            {
                _pool.Add(obj);
            }
        }
    }
}
