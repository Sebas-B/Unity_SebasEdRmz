using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // Obtiene la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime* speed);

        // Lleva al avion hacia arriba/abajo con base a la flechas arriba/abajo
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
