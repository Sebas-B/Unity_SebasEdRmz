using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Se declara un objeto Rigidbody
    private Rigidbody playerRb;
    // Se declara para la fuerza del salto
    public float jumpForce = 10;
    // Se declara un objeto Gravedad
    public float gravityModifier;
    // Valor booleano que verifica si se esta en en el suelo
    public bool isOnGround = true;
    // Se declara un mensaje game over
    public bool gameOver = false;

    void Start()
    {
        // Se obtiene el Rigidbody 
        playerRb = GetComponent<Rigidbody>();
        // Se le da un valor a la gravedad y esta se 
        // Multiplicacara por el valor que se le de
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        // Si se preciona espacio y se esta en el suelo el jugador saltara
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // Se cambia el valor cuando se esta en el aire
            isOnGround = false;
        }
    }

        private void OnCollisionEnter(Collision collision) {
        //Se verificac con que hubo colision
        if (collision.gameObject.CompareTag("Ground")) {
            // Se vuelve a estar en el suelo 
            // Al entrat en colision con el suelo
            isOnGround = true;
        } else if (collision.gameObject.CompareTag("Enemigo")) {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
