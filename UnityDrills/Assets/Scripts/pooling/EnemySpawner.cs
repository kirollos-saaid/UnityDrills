using ObjectPooling;
using UnityEngine;

namespace pooling
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private Enemy _enemyPrefab;
        [SerializeField] private Transform _parentTransform;
        [SerializeField] private float _spawnRate;
        [SerializeField] private int _maxEnemies;
        private ObjectPool<Enemy> _pooling;
        private float _currentRate = 0;

        void Start()
        {
            _pooling = new ObjectPool<Enemy>(_enemyPrefab, _maxEnemies, _parentTransform);
        }

        void Update()
        {
            _currentRate -= Time.deltaTime;
            
            if (_currentRate <=0)
            {
                _currentRate = _spawnRate;
                Enemy enemy = _pooling.Get();
                enemy.Init(() => _pooling.Return(enemy));
            }
        }
    }
}