using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para acciones del jugaor
public class PlayerControllerX : MonoBehaviour
{
    // Se toma al perro como proyectil
    public GameObject dogPrefab;
    // Numero de perros permitidos en pantalla
    private float cooldown = 1;

    void Update()
    {
        // Cuando se presiona espcio se manda un perro
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            // Se tiene que se mandara un perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Y se tendra la recarga en 1
            cooldown = 1;
        }
        // Si la recarga es mayor o igual a cero
        if (cooldown >= 0){
            // Se subtrae el valor de Time y se le asigna a cooldown
            cooldown -= Time.deltaTime;
        }
    }
    
}
