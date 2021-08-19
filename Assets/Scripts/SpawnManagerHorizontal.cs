using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerHorizontal : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnPositionX = 25.0f;
    private float spawnRangeZ = 5.0f;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.0f;
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() {
        Vector3 spawnPosition = new Vector3(direction * spawnPositionX, 0, Random.Range(0, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.Euler(new Vector3(0, -90 * direction, 0)));
        direction = direction * -1;
    }
}
