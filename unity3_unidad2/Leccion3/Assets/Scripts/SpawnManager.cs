using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Se toma el prefab del obsculo
    public GameObject obstaculoPrefab;
    // Posicion del prefab del Spawn
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Tiempo de espera de 2
    private float startDelay = 2;
    // Tiempo de repeticion
    private float repeatRate = 2;
    // Constante Script jugador
    private PlayerController playerControllerScript;
    void Start()
    {
        // Se hace la repeticion en el spawn con un tiempo de espera y salida
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        // Se toma al jugador
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        // Si se choca con el obstaculo dejaran de aparecer
        if(playerControllerScript.gameOver == false) 
        {
            Instantiate(obstaculoPrefab, spawnPos, obstaculoPrefab.transform.rotation);
        }
    }
}
