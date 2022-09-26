using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para destruir los objetos que salgan de pantalla
public class DestroyOutOfBounds : MonoBehaviour
{
    // Constante limite superior
    private float topBound = 30;
    // Constante limite inferior
    private float lowerBound = -10;

    void Start()
    {
        
    }

    void Update()
    {
        // si el objeto sale por la parte de arriba de la pantalla entonces se destruye
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        // ademas si el objeto sale por la parte inferior de la pantalla entonces se destruye
        // Y se manda por consola un mensaje de juego terminado
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
