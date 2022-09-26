using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    void Update()
    {

    }

    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        // Genera animales de mamnera aleatoria y una posicion aleatoira
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 
        0, spawnPosZ);

        Instantiate(animalsPrefabs[animalIndex], spawnPos,
            animalsPrefabs[animalIndex].transform.rotation);
    }
}
