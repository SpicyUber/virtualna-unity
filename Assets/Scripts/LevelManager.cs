
using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private float _distance;
    [SerializeField]
    private Transform _playerTransform;
    [SerializeField]
    private float _timeBetweenChunksInSeconds;
    [SerializeField]
    private float _timeBetweenDespawnInSeconds;
    [SerializeField]
    private Chunk[] _chunks;
    [SerializeField]
    Config _config;

    public List<GameObject> gameObjects;

    private float _spawnTimer = 0;
    private float _despawnTimer = 0;

    void Start() => gameObjects = new();

    void Update()
    {
        _spawnTimer += Time.deltaTime;
        _despawnTimer += Time.deltaTime;

        if (_spawnTimer >= _timeBetweenChunksInSeconds)
        {
            _spawnTimer = 0;

            int randIndex
                = UnityEngine.
                Random.Range(0,_chunks.Length);

            Chunk chunk = _chunks[randIndex];
            InstantiateChunk(chunk);
        }

        if (_despawnTimer >= _timeBetweenDespawnInSeconds)
        {
            _despawnTimer = 0;
            Despawn();
        }

    }

    private void Despawn()
    {
        for (int i = gameObjects.Count-1; i >= 0; i--)
        {
            if (!gameObjects[i])
            {
                gameObjects.RemoveAt(i);
                continue;
            }

                if (gameObjects[i].transform.position.z + 10 
                < _playerTransform.transform.position.z)
            {
                Debug.Log("DESTROYED AN OBJECT");
                Destroy(gameObjects[i]);
                gameObjects.RemoveAt(i);

            }

        }
    }

    private void InstantiateChunk(Chunk chunk) 
    {
        Vector3 distanceVec1 
            = new(-_config.Range, 0, _distance);
        Vector3 distanceVec2 
            = new(0, 0, _distance);
        Vector3 distanceVec3 
            = new(_config.Range, 0, _distance);

        Vector3 playerPos = _playerTransform.position;
        playerPos.x = 0;

        gameObjects.Add(Instantiate(chunk.Prefab1,
            playerPos + distanceVec1,
            Quaternion.identity,
            null
            )) ;

        gameObjects.Add(Instantiate(chunk.Prefab2,
            playerPos + distanceVec2,
            Quaternion.identity,
            null
            ));

        gameObjects.Add(Instantiate(chunk.Prefab3,
            playerPos + distanceVec3,
            Quaternion.identity,
            null
            ));
    }
}
