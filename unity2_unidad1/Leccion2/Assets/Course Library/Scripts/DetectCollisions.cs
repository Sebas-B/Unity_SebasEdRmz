using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para detecta cuando dos objetos se encuntran
public class DetectCollisions : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    // Cuando el objeto entre a la hitbox de otro ambos desapareceran
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
