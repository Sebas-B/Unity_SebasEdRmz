using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para mover las pelotas de manera vertical
public class MoveForwardX : MonoBehaviour
{
    public float speed;


    void Update()
    {
        // Movera los objetos
        // a determinada velociadad
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
