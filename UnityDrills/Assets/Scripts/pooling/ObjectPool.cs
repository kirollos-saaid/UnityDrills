using UnityEngine;
using System.Collections.Generic;

namespace ObjectPooling
{
    public class ObjectPool<T> where T : Component
    {
        private readonly Queue<T> _pool;
        private readonly T _prefab;
        private readonly Transform _parent;
        private readonly int _maxSize = 10;

        public ObjectPool(T prefab, int count, Transform parent)
        {
            _prefab = prefab;
            _parent = parent;

            _pool = new Queue<T>(count);
            for (int i = 0; i < count; i++)
            {
                Add();
            }
        }

        private T Add()
        {
            T component = Object.Instantiate(_prefab, Utilities.GetRandomPosition(), Quaternion.identity, _parent);
            component.gameObject.SetActive(false);
            _pool.Enqueue(component);
            return component;
        }

        public T Get()
        {
            if (_pool.Count == 0)
                Add();

            T component = _pool.Dequeue();
            component.gameObject.SetActive(true);
            return component;
        }

        public void Return(T obj)
        {
            obj.gameObject.SetActive(false);
            _pool.Enqueue(obj);
        }
    }
}