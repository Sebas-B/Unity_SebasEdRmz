using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    void Start()
    {
        SpawnRandomBall();
    }

    // Hace aparecer una pelota de manera aleatoria en la posicion x y en una posicion diferente en la parte de arriba de la pantalla
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generata una pelota aleatoria con posicion aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instancia una pelota en una posicion aleatoria
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(2f, 4f));
    }

}
