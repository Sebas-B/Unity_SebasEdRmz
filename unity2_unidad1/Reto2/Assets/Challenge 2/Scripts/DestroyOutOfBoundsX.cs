using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
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
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
