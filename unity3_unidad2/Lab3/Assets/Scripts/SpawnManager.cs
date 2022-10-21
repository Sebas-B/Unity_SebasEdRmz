using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Se toma el prefab del enemigo
    public GameObject enemigoPrefab;
    // Se toma el prefab de la capsule
    public GameObject capsulePrefab;
    // Posicion del prefab del Spawn
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Tiempo de espera de 2
    private float startDelay = 1.9f;
    // Tiempo de repeticion
    private float repeatRate = 1.9f;
    // Tiempo de espera capsula
    private float startDelayCapsule = 4.8f;
    // Tiempo de repeticion
    private float repeatRateCapsule = 4.8f;
    // Constante Script jugador
    private PlayerController playerControllerScript;
    void Start()
    {
        // Se hace la repeticion en el spawn con un tiempo de espera y salida
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnCapsule", startDelayCapsule, repeatRateCapsule);
        // Se toma al jugador
        playerControllerScript = GameObject.Find("Jugador").GetComponent<PlayerController>();
    }

    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        // Si se choca con el obstaculo dejaran de aparecer
        if(playerControllerScript.gameOver == false) 
        {
            Instantiate(enemigoPrefab, spawnPos, enemigoPrefab.transform.rotation);
        }
    }

    void SpawnCapsule ()
    {
        // Si se choca con el obstaculo dejaran de aparecer
        if(playerControllerScript.gameOver == false) 
        {
            Instantiate(capsulePrefab, spawnPos, capsulePrefab.transform.rotation);
        }
    }

}
