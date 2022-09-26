using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Constante velocidad
    public float speed;
    // constante velocidad de rotacion
    public float rotationSpeed;
    // constante entrada vertical del jugador
    public float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // Obtiene la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        // Toma la velocidad para moverse de manera horizontal de manera automatica
        transform.Translate(Vector3.forward*Time.deltaTime* speed);

        // Lleva al avion hacia arriba/abajo con base a la flechas arriba/abajo
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
