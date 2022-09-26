using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para destruir los objetos que salgan de pantalla
public class DestroyOutOfBoundsX : MonoBehaviour
{
     // Constante limite izquiera
    private float leftLimit = -30;
     // Constante limite boton
    private float bottomLimit = -5;

    void Start()
    {
        
    }


    void Update()
    {
        // Destruye a los perros si la posocion en c es menor que el limite izquierdo
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destruye las pelotas si la poscion de y es menor que el limite del fondo
        else if (transform.position.y < bottomLimit)
        {
            // Se destruye el objeto y se manda mensaje de gameboy
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
