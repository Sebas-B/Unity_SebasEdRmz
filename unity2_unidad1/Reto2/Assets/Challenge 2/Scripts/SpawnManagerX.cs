using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para hacer aparecer las pelotas de manera aleatoria
public class SpawnManagerX : MonoBehaviour
{
    // Se toma el prefab de las difentes pelotas
    public GameObject[] ballPrefabs;
    // Limite de X Izq
    private float spawnLimitXLeft = -22;
    // Limite de X Derecho
    private float spawnLimitXRight = 7;
    // Posiicion en Y en la que aparera el objeto
    private float spawnPosY = 30;

    void Start()
    {
        // Cada que se inicialice el juego llevara acabo la funcion SpawnRandomBall
        SpawnRandomBall();
    }

    // Hace aparecer una pelota de manera aleatoria en la posicion x y en una posicion diferente en la parte de arriba de la pantalla
    void SpawnRandomBall ()
    {
        // Indice de las pelotas por el tamaño del arrayh
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generata una pelota aleatoria con posicion aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instancia una pelota en una posicion aleatoria
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2f, 4f));
    }

}
