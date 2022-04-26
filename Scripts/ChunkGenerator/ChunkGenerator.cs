using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Chunk _firstChunk;
    [SerializeField] private Chunk[] _chunkPrefabs;

    private List<Chunk> _spawnedChunks = new List<Chunk>();
    private float paddingBetweenChunks = 10f;

    private void Start()
    {
        _spawnedChunks.Add(_firstChunk);
    }

    private void Update()
    {
        if (_player.transform.position.y > _spawnedChunks[_spawnedChunks.Count - 1].End.position.y - paddingBetweenChunks)
        {
            SpawnChunk();
            DestroyChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(_chunkPrefabs[Random.Range(0, _chunkPrefabs.Length)], transform);
        newChunk.transform.position = _spawnedChunks[_spawnedChunks.Count - 1].Begin.position - newChunk.End.localPosition;
        _spawnedChunks.Add(newChunk);
    }

    private void DestroyChunk()
    {
        int maximimumChunkCount = 4;

        if (_spawnedChunks.Count >= maximimumChunkCount)
        {
            Destroy(_spawnedChunks[0].gameObject);
            _spawnedChunks.RemoveAt(0);
        }
    }
}