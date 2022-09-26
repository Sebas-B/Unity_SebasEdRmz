using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Codigo para que la camara siga al jugador 
public class FollowPlayerX : MonoBehaviour
{
    // Se deine el objecto de juego
    // Que en este caso es el avion(plane) 
    public GameObject plane;
    //Se define la posicion de la camara
    private Vector3 offset = new Vector3(-23,3,3);

    void Start()
    {

    }

    void Update()
    {
        // La camara seguira a nuestro vehiculo
        transform.position = plane.transform.position + offset;
    }
}
