using System.Threading;
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
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // Si la constante gameOver es falsa seguiran saliendo obejetos
        if (playerControllerScript.gameOver == false) 
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
         
        // Si sale del limite y se trata de un obstaculo descruiye este mismo
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstaculo")) {
            Destroy(gameObject);
        }
    }
}
