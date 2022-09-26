using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para aparecer animales de manera aleatoria y pocision aleatoria
public class SpawnManager : MonoBehaviour
{
    // Toma una lista de los animales
    public GameObject[] animalsPrefabs;
    // Rango en el que apereceran en X
    private float spawnRangeX = 20;
    // Rango en el que apereceran en Z
    private float spawnPosZ = 20;
    // tiempo entre el que saldra animal 
    private float startDelay = 2;
    // Intervalo de distancia en el que apareceran los animales
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        // Iniciando apareceran los animales con su respectivo delay y distancia entre si
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    void Update()
    {

    }

    // Metodo que hace aparecer a los aniamles
    void SpawnRandomAnimal(){
        // Indice de los animales basado en el tamaño del arreglo
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        // Genera animales de mamnera aleatoria y una posicion aleatoira
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 
        0, spawnPosZ);

        // Intancia los animales para mandarlos a pantalla
        Instantiate(animalsPrefabs[animalIndex], spawnPos,
            animalsPrefabs[animalIndex].transform.rotation);
    }
}
