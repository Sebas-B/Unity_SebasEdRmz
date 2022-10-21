using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    // Constante velocidad
    private float speed = 15;
    // Constante Script jugador
    private PlayerController playerControllerScript;
    // Constante limite izquierdo
    private float leftBound = -15;
    void Start()
    {
        // Se toma al jugador
        playerControllerScript = GameObject.Find("Jugador").GetComponent<PlayerController>();
    }

    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed);
             
        // Si sale del limite y se trata de un obstaculo descruye este mismo
        if (transform.position.x < leftBound && gameObject.CompareTag("Enemigo") && gameObject.CompareTag("Capsule")) {
            Destroy(gameObject);
        }
    }
}
