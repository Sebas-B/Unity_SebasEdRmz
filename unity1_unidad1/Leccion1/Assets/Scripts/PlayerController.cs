using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controles del jugador
public class PlayerController : MonoBehaviour
{
    // Variable para velocidad
    public float velocidad;
    void Start()
    {
        
    }

    void Update()
    {
        // Indica que se el jugaodr presiona  arriba/abajo avanzara 
        float avanza = Input.GetAxis("Vertical");
        // Indica que se el jugaodr presiona izquierda/derecha gira 
        float girar = Input.GetAxis("Horizontal");
        
        // Toma los valores para transformar la poscion de traslado de jugador con la contante avanza
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        // Toma los valores para transformar la poscion de giro del jugador con la contante gira
        transform.Rotate(Vector3.up, Time.deltaTime * 30*girar);
    }
}
