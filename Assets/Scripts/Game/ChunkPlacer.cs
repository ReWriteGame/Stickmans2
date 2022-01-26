using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    [SerializeField] [Range(0,100)] private int numberOfChunk = 10;
    [SerializeField] private Chunk firstChunk;
    [SerializeField] private Chunk lastChunkPrefab;
    [SerializeField] private Chunk[] chunkPrefubs;// варианты префабов

    private List<Chunk> spawnedChunks = new List<Chunk>();

    public int NumberOfChunk { get => numberOfChunk; set => numberOfChunk = value; }

    private void Start()
    {
        spawnedChunks.Add(firstChunk);

        for (int i = 0; i < numberOfChunk; i++)
            SpawnRandomChunk();

        SetLastChunk();
    }

    private void SpawnRandomChunk()
    {
        Chunk newChunk = Instantiate(chunkPrefubs[Random.Range(0, chunkPrefubs.Length)], transform);// transform спавнит чанки дочерними
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;// делаем сдвиг 
        spawnedChunks.Add(newChunk);
    }

    private void DestroyChunk(int index = 0)
    {
        Destroy(spawnedChunks[index].gameObject);
        spawnedChunks.RemoveAt(index);
    }

    public Vector3 GetPosEndOfChunk(int index = 0)
    {
        return spawnedChunks[index].End.position;
    }
    public Vector3 GetPosBeginOfChunk(int index = 0)
    {
        return spawnedChunks[index].Begin.position;
    }
    
    public void SetLastChunk()
    {
        Chunk newChunk = Instantiate(lastChunkPrefab, transform);// transform спавнит чанки дочерними
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;// делаем сдвиг 
        spawnedChunks.Add(newChunk);
    }
}
