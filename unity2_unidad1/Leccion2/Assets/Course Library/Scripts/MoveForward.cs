using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para mover a los animales de manera vertical
public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Movera los objetos ya sea los enemigos o el proyectil
        // a determinada velociadad
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
