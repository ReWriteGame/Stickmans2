using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class SpawnStickmanZone : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnObjects;
    [Range(0, 100)] [SerializeField] private int objectOnPlatform = 5;

    


    private BoxCollider boxCollider;


    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();

        for (int i = 0; i < objectOnPlatform; i++)
            createObject();
    }

    void createObject()
    {
        GameObject newObject = Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], transform);// transform спавнит чанки дочерними
        newObject.transform.position = spawnPosition(boxCollider.transform.position, boxCollider.size);
    }

    private Vector3 spawnPosition(Vector3 center, Vector3 sizeSide )
    {
        Vector3 position;
        position.x = Random.Range(center.x - sizeSide.x / 2, center.x + sizeSide.x / 2);
        position.y = Random.Range(center.y - sizeSide.y / 2, center.y + sizeSide.y / 2);
        position.z = Random.Range(center.z - sizeSide.z / 2, center.z + sizeSide.z / 2);
        return position;
    }
}
