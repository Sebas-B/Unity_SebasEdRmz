//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    // Rigidbody de los objetos 
    private Rigidbody targetRB;
    // GameManager
    private GameManager gameManager;
    // Velocidad minima
    private float minSpeed = 12;
    // Velocidad maxima
    private float maxSpeed = 16;
    // Torque maximo
    private float maxTorque = 10;
    // Limite de x
    private float xRange = 4;
    // Los objetos aparecen desde la posicion y
    private float ySpawnPos = -2;
    // puntos
    public int pointValue;
    // Explosion
    public ParticleSystem explosionParticle;

    void Start()
    {
        // Se toma el Rigidbody de los objetos
        targetRB = GetComponent<Rigidbody>();
        // Se les da un impuloso
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        // Se les da una posicion de aparicion de manera aleatoria dentro de los limites
        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        // Posicion en la que aparecer los limites
        transform.position = RandomSpawnPos();
        // Se toma el game manajer
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();  
    }

    void Update()
    {
        
    }

    // Funcion que indica que hara el juego cuando se toquen los objetos
    private void OnMouseDown() 
    {
        if (gameManager.isGameActive) {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(gameObject); 
            gameManager.UpdateScore(pointValue);
        }
    }

    // Funcion que valida si un objeto sale de pantalla
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);   
        if(!gameObject.CompareTag("Bad")){
            gameManager.GameOver();
        }
    }

    // Funcion que asigna un rango random
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    // Funcion que asigna un rango random
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

     // Funcion que asigna un rango random
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

}
