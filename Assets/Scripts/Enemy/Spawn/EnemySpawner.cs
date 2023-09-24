using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawnPosition;

    [SerializeField] private Enemy _enemyPrefab;

    [SerializeField] [Min(0.0f)] private int _spawnCount;
    [SerializeField] [Min(0.0f)] private int _minDistanceBetwenSpawn;
    [SerializeField] [Min(0.0f)] private int _maxDistanceBetwenSpawn;

    private Transform _previousSpawnPosition;

    private void Start() 
    {
        _previousSpawnPosition = _playerSpawnPosition;

        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for(int i = 0; i < _spawnCount; i++)
        {
            int randomXPosition = Random.Range(_minDistanceBetwenSpawn, _maxDistanceBetwenSpawn);
            Vector3 spawnPosition = new Vector3(_previousSpawnPosition.position.x + randomXPosition, 0, 0);

            Enemy enemy = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);

            _previousSpawnPosition = enemy.transform;
        }
    }
}
