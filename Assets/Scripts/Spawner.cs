using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elepserTime = 0;

    private void Update()
    {
        _elepserTime += Time.deltaTime;

        if(_elepserTime >= _secondsBetweenSpawn)
        {
            _elepserTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[spawnPointNumber]);

            //TrySpawnEnemys();
        }
    }

    private void TrySpawnEnemys()
    {

    }
}
