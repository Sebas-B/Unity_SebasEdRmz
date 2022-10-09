using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Variable posicion inicial
    private Vector3 startPos; 
    // Variable ancho repeticion
    private float repeatWidth;

    void Start()
    {
        // La posicion toma la posicion 
        startPos = transform.position;
        // Repeticion inicial
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    { 
        // Si la posicion del fondo es menor a la posicion en 
        //la que se repite estantomara la poscion inicial
        if (transform.position.x < startPos.x - repeatWidth) {
            transform.position = startPos;
        }
    }
} 
 