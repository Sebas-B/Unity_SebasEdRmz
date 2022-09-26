using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Codigo para que la camara siga al jugador 
public class CamaraController : MonoBehaviour
{
    // Se define el objecto de juego
    // Que en este caso es el vehiculo
    public GameObject maquinaMisterio;
    // Posicion que tendra la camara
    private Vector3 pos = new Vector3(0,5,-10);

    void Start()
    {
        
    }

    void Update()
    {
        // La camara seguira a nuestro vehiculo
        transform.position = maquinaMisterio.transform.position + pos;
    }
}
