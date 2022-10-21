﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetX : MonoBehaviour
{
    private Rigidbody rb;
    private GameManagerX gameManagerX;
    public int pointValue;
    public GameObject explosionFx;

    public float timeOnScreen = 1.0f;

    private float minValueX = -3.75f; // el valor x del centro del cuadrado más a la izquierda
    private float minValueY = -3.75f; // el valor y del centro del cuadrado más bajo
    private float spaceBetweenSquares = 2.5f; // la distancia entre los centros de las casillas del tablero de juego
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();

        transform.position = RandomSpawnPosition(); 
        StartCoroutine(RemoveObjectRoutine()); // iniciar el temporizador antes de que el objetivo salga de la pantalla

    }

    // Cuando se hace clic en el objetivo, lo destruye, actualiza la puntuación y genera una explosión
    private void OnMouseDown()
    {
        if (gameManagerX.isGameActive)
        {
            Destroy(gameObject);
            gameManagerX.UpdateScore(pointValue);
            Explode();
        }
               
    }

    Vector3 RandomSpawnPosition()
    {
        float spawnPosX = minValueX + (RandomSquareIndex() * spaceBetweenSquares);
        float spawnPosY = minValueY + (RandomSquareIndex() * spaceBetweenSquares);

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;

    }

    // Genera un índice de cuadrado aleatorio de 0 a 3, que determina en qué cuadrado aparecerá el objetivo
    int RandomSquareIndex ()
    {
        return Random.Range(0, 4);
    }


    // Si el objetivo que NO es el objeto malo colisiona con el sensor, desencadena el fin del juego
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (other.gameObject.CompareTag("Sensor") && !gameObject.CompareTag("Bad"))
        {
            gameManagerX.GameOver();
        } 

    }

    // Mostrar la partícula de la explosión en la posición del objeto
    void Explode ()
    {
        Instantiate(explosionFx, transform.position, explosionFx.transform.rotation);
    }

    // Tras un retardo, mueve el objeto detrás del fondo para que colisione con el objeto del sensor
    IEnumerator RemoveObjectRoutine ()
    {
        yield return new WaitForSeconds(timeOnScreen);
        if (gameManagerX.isGameActive)
        {
            transform.Translate(Vector3.forward * 5, Space.World);
        }

    }

}