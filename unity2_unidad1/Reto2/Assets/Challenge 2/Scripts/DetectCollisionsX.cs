using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para detecta cuando dos objetos se encuntran
public class DetectCollisionsX : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Cuando el objeto entre a la hitbox del objeto la pelota desaparece
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }

}
